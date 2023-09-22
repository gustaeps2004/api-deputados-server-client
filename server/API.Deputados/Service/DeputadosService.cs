using API.Deputados.Models;
using RestSharp;
using System.Xml.Serialization;

namespace API.Deputados.Service
{
    public class DeputadosService : IDeputados
    {
        public async Task<Root> GetAllDeputados(int pagina, int itens)
        {
            if(!Int32.TryParse(pagina.ToString(), out int numberPagina) || !Int32.TryParse(itens.ToString(), out int numberItens))
            {
                throw new Exception("Número da página ou itens não é um número válido!");
            }

            var client = new RestClient($"https://dadosabertos.camara.leg.br/api/v2/deputados?pagina={pagina}&itens={itens}&ordem=ASC&ordenarPor=nome");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("accept", "application/xml");
            var response = client.ExecuteGet(request);

            XmlSerializer serializer = new(typeof(Root));
            using (TextReader reader = new StringReader(response.Content))
            {
                Root root = (Root)serializer.Deserialize(reader);
                return root;
            }
        }
    }
}
