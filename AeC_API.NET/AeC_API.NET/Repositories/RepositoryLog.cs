using AeC_API.NET.Entities;
using AeC_API.NET.Repositories.Entities;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AeC_API.NET.Repositories
{
    public class RepositoryLog
    {
        private readonly ILogger _logger;

        public RepositoryLog(ILogger<RepositoryLog> logger)
        {
            _logger = logger;
        }

        public async void Inserir(Repositories.Entities.Log log)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Perfil.ConnectionStrings))
                {
                    string insertQuery = @"INSERT INTO [dbo].[Log]([NomeRota], [DescricaoErro], [DataHora]) VALUES (@NomeRota, @DescricaoErro, @DataHora)";

                    var result = db.Execute(insertQuery, log);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

        }
    }
}
