using AeC_API.NET.Repositories;
using Microsoft.Extensions.Logging;

namespace AeC_API.NET.Test
{    
    public class UnitRepositoryClima
    {
        private readonly ILogger<RepositoryClima> _loggerClima; 

        [Test]
        public void Inserir()
        {
            var _clima = new Repositories.Entities.Clima()
            {
                NomeRota = "Inserir",
                JsonData = "Arquivo JSON",
                DataHora = DateTime.Now
            };
            RepositoryClima _repositoryClima = new RepositoryClima(_loggerClima);
            _repositoryClima.Inserir(_clima);
        }
    }
}
