using SanaPass_EBAAMS.Interfaces;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SanaPass_EBAAMS.DataRepo
{
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public MySqlConnectionFactory()
        {
            _connectionString =
                ConfigurationManager
                    .ConnectionStrings["EBAAMS_DB"]
                    ?.ConnectionString
                ?? "Server=localhost;Database=sanapass_ebaams;Uid=root;Pwd=;";
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}