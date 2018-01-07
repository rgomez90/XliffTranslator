using System.Xml.Serialization;

namespace PLSTranslator
{
    [XmlRoot(ElementName = "xliff")]
    public class Xliff
    {
        [XmlElement(ElementName = "file")]
        public File File { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }
}

