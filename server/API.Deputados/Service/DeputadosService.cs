using API.Deputados.Models;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Serializers;
using System.Xml.Linq;
using Microsoft.OpenApi.Writers;
using System.Xml.Serialization;

namespace API.Deputados.Service
{
    public class DeputadosService : IDeputados
    {
        public async void/*Task<List<Deputado>>*/ GetAllDeputados()
        {
            var client = new RestClient("https://dadosabertos.camara.leg.br/api/v2/deputados?ordem=ASC&ordenarPor=nome");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("accept", "application/xml");
            var response = client.ExecuteGet(request);

            //var newDeputados = await SeparateDeputados(deputados!);

            //return newDeputados;
        }
    }
}
