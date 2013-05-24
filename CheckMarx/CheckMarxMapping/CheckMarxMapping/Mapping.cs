using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CheckMarxMapping
{
    [Serializable]
    public class DataItem
    {
        [XmlAttribute]
        public int QueryId { get; set; }

        [XmlAttribute]
        public String Guid { get; set; }
    }

    [Serializable]
    public class CheckMarxDataMapping
    {
        [XmlArray] public List<DataItem> Mapping;

        public CheckMarxDataMapping()
        {
            Mapping = new List<DataItem>();
        }
    }
}