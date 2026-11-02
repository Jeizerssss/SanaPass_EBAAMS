using MySql.Data.MySqlClient;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IDbConnectionFactory
    {
        MySqlConnection CreateConnection();
    }
}