using AeC_API.NET.Entities;
using AeC_API.NET.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AeC_API.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimaController : ControllerBase
    {
        private readonly ILogger<ClimaController> _logger;
        private readonly IIntegracaoBrasilAPI _integracaoBrasilAPI;

        public ClimaController(ILogger<ClimaController> logger, IIntegracaoBrasilAPI integracaoBrasilAPI)
        {
            _logger = logger;
            _integracaoBrasilAPI = integracaoBrasilAPI;
        }
                
        [HttpGet("ConsultarCidades")]
        public async Task<List<Cidade>> GetCidades()
        {            
            return await _integracaoBrasilAPI.ConsultarCidades();
        }
                
        [HttpGet("ConsultarPorCodigoCidade")]
        public async Task<Previsao> GetPorCodigoCidade(string cityCode)
        {            
            return await _integracaoBrasilAPI.ConsultarClimaPorCodigoCidade(cityCode);
        }

        [HttpGet("ConsultarAeroportos")]
        public async Task<List<Aeroporto>> GetAeroportos()
        {            
            return await _integracaoBrasilAPI.ConsultarAeroportos();
        }

        [HttpGet("ConsultarPorCodigoAeroporto")]
        public async Task<Aeroporto> GetPorCodigoAeroporto(string icaoCode)
        {            
            return await _integracaoBrasilAPI.ConsultarClimaPorCodigoAeroporto(icaoCode);
        }
    }
}
