using API.Deputados.Models;

namespace API.Deputados.Service
{
    public interface IDeputados
    {
        Task<Root> GetAllDeputados(int pagina, int itens);
    }
}
