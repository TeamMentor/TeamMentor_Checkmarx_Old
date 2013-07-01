using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using NUnit.Framework;
using System.Reflection;

namespace CheckMarxMapping.Test
{
    public class Base
    {
        public readonly string HtmlRedirectionTemplate = "<html><head><meta http-equiv=\"refresh\" content=\"0;" +
                                                            "url=http://checkmarx.teammentor.net/article/{0}\"></head></html>";
        protected List<DataItem> GetData()
        {
            const string ResourceName = "CxWebInterface.Test.Resources.CheckMarxMapping.xml";
            CheckMarxDataMapping Mapping = null;

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(ResourceName))
            {
                Assert.IsTrue(stream != null);

                using (var reader = new StreamReader(stream))
                {
                    var serializer = new XmlSerializer(typeof (CheckMarxDataMapping));
                    Mapping = (CheckMarxDataMapping) serializer.Deserialize(reader);
                }
            }
            Assert.IsTrue(Mapping != null);
            return Mapping.Mapping;
        }
    }
}