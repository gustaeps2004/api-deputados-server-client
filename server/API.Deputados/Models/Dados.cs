using System.Xml.Serialization;

namespace API.Deputados.Models
{
    public class Dados
    {
        [XmlElement]
        public List<Deputado> dados { get; set; }
    }
}
