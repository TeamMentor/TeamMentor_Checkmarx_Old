using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NUnit.Framework;
using O2.DotNetWrappers.ExtensionMethods;

namespace CheckMarxMapping.Test
{
    [TestFixture]
    public class CheckMarxMapping : Base
    {
        [Test]
        public void DataItemsAreCorrect()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};

            Assert.IsTrue(DataMapping.Mapping.notNull());

            Assert.IsTrue(DataMapping.Mapping.Count == 95);
        }

        [Test]
        [Description(
            "In checkmarx there might be several articles with the same CWE but the QueryId is different, also the QueryId might be the same, but" +
            "TeamMentor article's GUI is different")]
        public void DataItems_Are_Not_Duplicated()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};
            List<DataItem> mapping = DataMapping.Mapping;

            int filteredResults = mapping.GroupBy(x => x.QueryId)
                                         .Where(group => group.Count() > 1)
                                         .Select(group => group.Key).Count();

            //FilteredResults equals 0 means that there are not duplicated
            Assert.IsTrue(filteredResults.notNull());
            Assert.IsTrue(filteredResults == 0);
        }

        [Test]
        public void Mapping_Contains_Elements_With_Same_GUID_But_Different_QueryID()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};
            List<DataItem> mapping = DataMapping.Mapping;

            List<IGrouping<string, DataItem>> resultsWithSameGUID = mapping.GroupBy(x => x.Guid)
                                                                           .Where(group => group.Count() > 1)
                                                                           .Select(x => x).ToList();

            //There should be DataItems with the same GUID
            Assert.IsTrue(resultsWithSameGUID.notNull());
            Assert.IsTrue(resultsWithSameGUID.Count > 0);

            //Those DataItems with the same GUID should have different QueryID
            List<IGrouping<int, DataItem>> results = mapping.GroupBy(x => x.QueryId)
                                                            .Where(group => group.Count() > 1)
                                                            .Select(x => x).ToList();

            Assert.IsTrue(results.notNull());
            Assert.IsTrue(results.count() == 0);
        }

        [Test]
        public void Serialization_And_Deserialization_Looks_Good()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};

            var serializer = new XmlSerializer(DataMapping.GetType());
            string xmlResult;

            using (var ms = new MemoryStream())
            {
                using (var sw = new StreamWriter(ms))
                {
                    serializer.Serialize(sw, DataMapping);
                    xmlResult = Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            //xmlResult.saveAs(@"C:\temp\CheckMarxMapping.xml");
            //Deserializing
            CheckMarxDataMapping deserializedResult;
            using (var reader = new StringReader(xmlResult))
            {
                deserializedResult = (CheckMarxDataMapping) serializer.Deserialize(reader);
            }

            Assert.IsTrue(deserializedResult.notNull());
            Assert.IsTrue(deserializedResult.Mapping.Count() == 95);
        }
    }
}