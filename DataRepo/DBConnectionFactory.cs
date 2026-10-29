using System.Configuration;
using MySql.Data.MySqlClient;

namespace SanaPass_EBAAMS.DataRepo
{
    public static class DbConnectionFactory
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["EBAAMS_DB"]?.ConnectionString
            ?? "Server=localhost;Database=sanapass_ebaams;Uid=root;Pwd=;";

        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}