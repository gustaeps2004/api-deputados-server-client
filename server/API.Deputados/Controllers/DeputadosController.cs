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

        [HttpGet("GetAllDeputados")]
        public async Task<IActionResult> GetAll()
        {
            var deputados = await _services.GetAllDeputados();

            return Ok(deputados);
        }
    }
}
