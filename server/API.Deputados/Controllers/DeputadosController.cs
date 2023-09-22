using API.Deputados.Models;
using API.Deputados.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Deputados.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeputadosController : ControllerBase
    {
        private readonly IDeputados _services;

        public DeputadosController(IDeputados services)
        {
            _services = services;
        }

        [HttpGet("GetAllDeputados/{pagina:int}/{itens:int}")]
        public async Task<IActionResult> GetAll(int pagina, int itens)
        {           
            try
            {
                var deputados = _services.GetAllDeputados(pagina, itens);
                return Ok(deputados.Result.dados);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
