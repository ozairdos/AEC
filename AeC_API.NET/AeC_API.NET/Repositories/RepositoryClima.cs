using AeC_API.NET.Repositories.Entities;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AeC_API.NET.Repositories
{
    public class RepositoryClima
    {
        private readonly ILogger _logger;

        public RepositoryClima(ILogger<RepositoryClima> logger)
        {
            _logger = logger;
        }

        public async void Inserir(Repositories.Entities.Clima clima)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Perfil.ConnectionStrings))
                {
                    string insertQuery = @"INSERT INTO [dbo].[Clima]([NomeRota], [JsonData], [DataHora]) VALUES (@NomeRota, @JsonData, @DataHora)";

                    var result = db.Execute(insertQuery, clima);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }                      
        }
    }
}
