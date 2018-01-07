using System.Xml.Serialization;

namespace PLSTranslator
{
    [XmlRoot(ElementName = "file")]
    public class File
    {
        
            [XmlElement(ElementName = "header")]
            public string Header { get; set; }
            [XmlElement(ElementName = "body")]
            public Body Body { get; set; }
            [XmlAttribute(AttributeName = "source-language")]
            public string Sourcelanguage { get; set; }
            [XmlAttribute(AttributeName = "target-language")]
            public string Targetlanguage { get; set; }
            [XmlAttribute(AttributeName = "datatype")]
            public string Datatype { get; set; }
            [XmlAttribute(AttributeName = "original")]
            public string Original { get; set; }
            [XmlAttribute(AttributeName = "date")]
            public string Date { get; set; }
            [XmlAttribute(AttributeName = "product-name")]
            public string Productname { get; set; }
        }
}
