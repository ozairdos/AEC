using AeC_API.NET.Repositories;
using AeC_API.NET.Services;
using Microsoft.Extensions.Logging;

namespace AeC_API.NET.Test
{
    public class UnitIntegracaoBrasilAPI
    {
        private readonly ILogger<RepositoryClima> _loggerClima;
        private readonly ILogger<RepositoryLog> _loggerLog;        

        [Test]
        public void ConsultarCidades()
        {
            IntegracaoBrasilAPI _integracaoBrasilAPI = new IntegracaoBrasilAPI(_loggerClima, _loggerLog);
            _integracaoBrasilAPI.ConsultarCidades().Wait();
        }

        [Test]
        public void ConsultarClimaPorCodigoCidade()
        {
            IntegracaoBrasilAPI _integracaoBrasilAPI = new IntegracaoBrasilAPI(_loggerClima, _loggerLog);
            _integracaoBrasilAPI.ConsultarClimaPorCodigoCidade("4750").Wait();
        }

        [Test]
        public void ConsultarAeroportos()
        {
            IntegracaoBrasilAPI _integracaoBrasilAPI = new IntegracaoBrasilAPI(_loggerClima, _loggerLog);
            _integracaoBrasilAPI.ConsultarAeroportos().Wait();
        }

        [Test]
        public void ConsultarClimaPorCodigoAeroporto()
        {
            IntegracaoBrasilAPI _integracaoBrasilAPI = new IntegracaoBrasilAPI(_loggerClima, _loggerLog);
            _integracaoBrasilAPI.ConsultarClimaPorCodigoAeroporto("SBAR").Wait();
        }
    }
}
