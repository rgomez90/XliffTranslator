using System.Collections.Generic;
using System.Xml.Serialization;

namespace PLSTranslator
{
    [XmlRoot(ElementName = "body")]
    public class Body
    {
        [XmlElement(ElementName = "trans-unit")]
        public List<TransUnit> Transunit { get; set; }
    }
}
