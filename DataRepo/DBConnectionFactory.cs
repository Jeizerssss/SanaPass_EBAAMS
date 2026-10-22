using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.DataRepo
{
    public static class DbConnectionFactory
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
            ?? @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SanaPass_EBAAMS_DB;Integrated Security=True;";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
