using System.Xml.Serialization;

namespace API.Deputados.Models
{
    [XmlRoot(ElementName = "deputado_")]
    public class Deputado
    {
        public string id { get; set; }
        public string uri { get; set; }
        public string nome { get; set; }
        public string siglaPartido { get; set; }
        public string uriPartido { get; set; }
        public string siglaUf { get; set; }
        public string idLegislatura { get; set; }
        public string urlFoto { get; set; }
        public string email { get; set; }
    }
}

