using System.Xml.Serialization;

namespace PLSTranslator
{
    [XmlRoot(ElementName = "trans-unit")]
    public class TransUnit
    {
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "target")]
        public string Target { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}
