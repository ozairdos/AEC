using AeC_API.NET.Entities;
using AeC_API.NET.Interfaces;
using AeC_API.NET.Repositories;
using Newtonsoft.Json;
using System.Net;

namespace AeC_API.NET.Services
{
    public class IntegracaoBrasilAPI : IIntegracaoBrasilAPI
    {
        private readonly ILogger<RepositoryClima> _loggerClima;
        private readonly ILogger<RepositoryLog> _loggerLog;
        public IntegracaoBrasilAPI(ILogger<RepositoryClima> loggerClima, ILogger<RepositoryLog> loggerLog)
        {
            _loggerClima = loggerClima;
            _loggerLog = loggerLog;
        }

        public async Task<List<Cidade>> ConsultarCidades()
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/cptec/v1/cidade";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://brasilapi.com.br" + GET);
                httpWebRequest.Method = "GET";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<List<Cidade>>(responseString.ToString());

                var _clima = new Repositories.Entities.Clima()
                {
                    NomeRota = "ConsultarCidades",
                    JsonData = responseString.ToString(),
                    DataHora = DateTime.Now
                };

                RepositoryClima _repositoryClima = new RepositoryClima(_loggerClima);
                _repositoryClima.Inserir(_clima);
                return retornoAPI;
            }
            catch (Exception ex)
            {
                var _log = new Repositories.Entities.Log()
                {
                    NomeRota = "ConsultarCidades",
                    DescricaoErro = ex.Message,
                    DataHora = DateTime.Now
                };

                RepositoryLog _repositoryLog = new RepositoryLog(_loggerLog);
                _repositoryLog.Inserir(_log);
                return null;
            }
        }

        public async Task<Previsao> ConsultarClimaPorCodigoCidade(string cityCode)
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/cptec/v1/clima/previsao/" + cityCode;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://brasilapi.com.br" + GET);
                httpWebRequest.Method = "GET";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<Previsao>(responseString.ToString());

                var _clima = new Repositories.Entities.Clima()
                {
                    NomeRota = "ConsultarPorCodigoCidade",
                    JsonData = responseString.ToString(),
                    DataHora = DateTime.Now
                };

                RepositoryClima _repositoryClima = new RepositoryClima(_loggerClima);
                _repositoryClima.Inserir(_clima);
                return retornoAPI;
            }
            catch (Exception ex)
            {
                var _log = new Repositories.Entities.Log()
                {
                    NomeRota = "ConsultarPorCodigoCidade",
                    DescricaoErro = ex.Message,
                    DataHora = DateTime.Now
                };

                RepositoryLog _repositoryLog = new RepositoryLog(_loggerLog);
                _repositoryLog.Inserir(_log);
                return null;
            }
        }

        public async Task<List<Aeroporto>> ConsultarAeroportos()
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/cptec/v1/clima/capital";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://brasilapi.com.br" + GET);
                httpWebRequest.Method = "GET";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<List<Aeroporto>>(responseString.ToString());

                var _clima = new Repositories.Entities.Clima()
                {
                    NomeRota = "ConsultarAeroportos",
                    JsonData = responseString.ToString(),
                    DataHora = DateTime.Now
                };

                RepositoryClima _repositoryClima = new RepositoryClima(_loggerClima);
                _repositoryClima.Inserir(_clima);
                return retornoAPI;
            }
            catch (Exception ex)
            {
                var _log = new Repositories.Entities.Log()
                {
                    NomeRota = "ConsultarAeroportos",
                    DescricaoErro = ex.Message,
                    DataHora = DateTime.Now
                };

                RepositoryLog _repositoryLog = new RepositoryLog(_loggerLog);
                _repositoryLog.Inserir(_log);
                return null;
            }
        }

        public async Task<Aeroporto> ConsultarClimaPorCodigoAeroporto(string icaoCode)
        {
            string retorno = string.Empty;
            try
            {
                string GET = "/api/cptec/v1/clima/aeroporto/" + icaoCode;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://brasilapi.com.br" + GET);
                httpWebRequest.Method = "GET";

                var response = (HttpWebResponse)httpWebRequest.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var retornoAPI = JsonConvert.DeserializeObject<Aeroporto>(responseString.ToString());

                var _clima = new Repositories.Entities.Clima()
                {
                    NomeRota = "ConsultarPorCodigoAeroporto",
                    JsonData = responseString.ToString(),
                    DataHora = DateTime.Now
                };

                RepositoryClima _repositoryClima = new RepositoryClima(_loggerClima);
                _repositoryClima.Inserir(_clima);
                return retornoAPI;
            }
            catch (Exception ex)
            {
                var _log = new Repositories.Entities.Log()
                {
                    NomeRota = "ConsultarPorCodigoAeroporto",
                    DescricaoErro = ex.Message,
                    DataHora = DateTime.Now
                };

                RepositoryLog _repositoryLog = new RepositoryLog(_loggerLog);
                _repositoryLog.Inserir(_log);
                return null;
            }
        }
    }
}
