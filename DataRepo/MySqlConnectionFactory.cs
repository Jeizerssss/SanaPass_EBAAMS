using SanaPass_EBAAMS.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace SanaPass_EBAAMS.DataRepo
{
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public MySqlConnectionFactory()
            : this(GetConfiguredConnectionString())
        {
        }

        public MySqlConnectionFactory(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException(
                    "A database connection string is required.",
                    nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        private static string GetConfiguredConnectionString()
        {
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["EBAAMS_DB"];

            if (settings == null ||
                string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new ConfigurationErrorsException(
                    "The 'EBAAMS_DB' connection string is missing from App.config.");
            }

            return settings.ConnectionString;
        }
    }
}