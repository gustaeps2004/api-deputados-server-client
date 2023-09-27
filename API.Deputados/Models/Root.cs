using System.Xml.Serialization;

namespace API.Deputados.Models
{
    [XmlRoot(ElementName = "xml")]
    public class Root
    {
        public Dados dados { get; set; }
    }
}
