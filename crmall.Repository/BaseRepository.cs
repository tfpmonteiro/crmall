using crmall.Repository.Map;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace crmall.Repository
{
    public abstract class BaseRepository
    {
        protected SqlConnection Conexao;

        public BaseRepository()
        {
            ConfigMapDapper.Carregar();
            Conexao = new SqlConnection(GetStringConnect());
        }

        private string GetStringConnect()
        {
            var host = ConfigurationManager.AppSettings["DbHost"];
            var database = ConfigurationManager.AppSettings["DbName"];

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(database))
                throw new Exception("Verificar os dados de conexão com a base de dados no arquivo de configuração.");

            var builder = new SqlConnectionStringBuilder
            {
                ApplicationName = "CRMALL",
                DataSource = host,
                InitialCatalog = database,
                UserID = "sa",
                Password = "sys@36911",
                ConnectRetryCount = 1,
                ConnectTimeout = 120,
                MinPoolSize = 5,
                MaxPoolSize = 10
            };

            return builder.ConnectionString;
        }
    }
}
