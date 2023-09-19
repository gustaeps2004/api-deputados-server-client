using API.Deputados.Models;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Serializers;

namespace API.Deputados.Service
{
    public class DeputadosService : IDeputados
    {
        public async Task<List<Deputado>> GetAllDeputados()
        {
            var client = new RestClient("https://dadosabertos.camara.leg.br/api/v2/deputados?ordem=ASC&ordenarPor=nome");
            var request = new RestRequest("", Method.Get);
            
            var response = client.ExecuteGet(request);

            var deputados = JsonConvert.DeserializeObject<Dados>(response.Content!.ToString());

            var newDeputados = await SeparateDeputados(deputados!);

            return newDeputados;
        }

        private async Task<List<Deputado>> SeparateDeputados(Dados deputados)
        {
            List<Deputado> newDeputados = new();
            int count = 0;
            foreach (var dep in deputados.dados)
            {
                if(count > 3)
                {
                    break;
                }
                newDeputados.Add(dep);
                                
                count++;
            }

            return newDeputados;
        }
    }
}
