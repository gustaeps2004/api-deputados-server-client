using System.Xml.Serialization;

namespace API.Deputados.Models
{
    [XmlRoot(ElementName = "dados")]
    public class Dados
    {
        [XmlElement(ElementName = "deputado_")]
        public List<Deputado> Deputados { get; set; }
    }
}
