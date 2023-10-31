using AeC_API.NET.Repositories;
using Microsoft.Extensions.Logging;

namespace AeC_API.NET.Test
{
    public class UnitRepositoryLog
    {       
        private readonly ILogger<RepositoryLog> _loggerLog;        

        [Test]
        public void Inserir()
        {
            var _log = new Repositories.Entities.Log()
            {
                NomeRota = "Inserir",
                DescricaoErro = "Mensagem de erro",
                DataHora = DateTime.Now
            };
            RepositoryLog _repositoryLog = new RepositoryLog(_loggerLog);
            _repositoryLog.Inserir(_log);
        }
    }
}
