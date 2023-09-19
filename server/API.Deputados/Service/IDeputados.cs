using API.Deputados.Models;

namespace API.Deputados.Service
{
    public interface IDeputados
    {
        Task<List<Deputado>> GetAllDeputados();
    }
}
