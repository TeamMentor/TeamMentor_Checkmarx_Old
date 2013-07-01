using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using CheckMarxMapping.Test;
using NUnit.Framework;

namespace CxWebInterface.Test
{
    [TestFixture]
    public class CheckMarxMapping : Base
    {
       
        [Test,Description("This test loads the CheckMarx XML mapping and verifies that all recods were loaded")]
        public void CheckMarx_DataItems_AreCorrect()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};

            Assert.IsTrue(DataMapping.Mapping!=null);

            Assert.IsTrue(DataMapping.Mapping.Count == 114);
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
            Assert.IsTrue(condition: true);
            Assert.IsTrue(filteredResults == 0);
        }

        [Test]
        [Description("We are mapping the same TeamMentor article for different CWEs. But each QueryId is different")]
        public void Mapping_Contains_Elements_With_Same_GUID_But_Different_QueryID()
        {
            var DataMapping = new CheckMarxDataMapping {Mapping = GetData()};
            List<DataItem> mapping = DataMapping.Mapping;

            List<IGrouping<string, DataItem>> resultsWithSameGUID = mapping.GroupBy(x => x.Guid)
                                                                           .Where(group => group.Count() > 1)
                                                                           .Select(x => x).ToList();

            //There should be DataItems with the same GUID
            Assert.IsTrue(resultsWithSameGUID!=null);
            Assert.IsTrue(resultsWithSameGUID.Count > 0);

            //Those DataItems with the same GUID should have different QueryID
            List<IGrouping<int, DataItem>> results = mapping.GroupBy(x => x.QueryId)
                                                            .Where(group => group.Count() > 1)
                                                            .Select(x => x).ToList();

            Assert.IsTrue(results!=null);
            Assert.IsTrue(results.Count == 0);
        }

        [Test]
        [Description("Given the XML mapping, we need to serialize and deserialize the results")]
        public void Serialization_And_Deserialization_Works_Ok()
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
           
            CheckMarxDataMapping deserializedResult;
            using (var reader = new StringReader(xmlResult))
            {
                deserializedResult = (CheckMarxDataMapping) serializer.Deserialize(reader);
            }

            Assert.IsTrue(deserializedResult!=null);
            Assert.IsTrue(deserializedResult.Mapping.Count() == 114);
        }

       
    }
}