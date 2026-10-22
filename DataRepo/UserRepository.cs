using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.DataRepo
{
    public class UserRepository : IUserRepository
    {
        public User getById(int userID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users WHERE userID = @userID", conn);
                cmd.Parameters.AddWithValue("@userID", userID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToUser(reader);
                    }
                }
            }
            return null;
        }

        public User getByUsername(string username)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users WHERE username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToUser(reader);
                    }
                }
            }
            return null;
        }

        public User validateLogin(string username, string password)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users WHERE username = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToUser(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<User> getAll()
        {
            var users = new List<User>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(MapToUser(reader));
                    }
                }
            }
            return users;
        }

        public bool add(User user)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Users (username, password, uLName, uFName, uMName, uEmail, uContactNumber, uRole) 
                              VALUES (@username, @password, @uLName, @uFName, @uMName, @uEmail, @uContactNumber, @uRole)";
                var cmd = new SqlCommand(query, conn);
                BindParameters(cmd, user);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool update(User user)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Users SET username = @username, password = @password, uLName = @uLName, 
                              uFName = @uFName, uMName = @uMName, uEmail = @uEmail, uContactNumber = @uContactNumber, 
                              uRole = @uRole WHERE userID = @userID";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", user.userID);
                BindParameters(cmd, user);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool delete(int userID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Users WHERE userID = @userID", conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private User MapToUser(SqlDataReader reader)
        {
            return new User
            {
                userID = Convert.ToInt32(reader["userID"]),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                uLName = reader["uLName"].ToString(),
                uFName = reader["uFName"].ToString(),
                uMName = reader["uMName"].ToString(),
                uEmail = reader["uEmail"].ToString(),
                uContactNumber = reader["uContactNumber"].ToString(),
                uRole = reader["uRole"].ToString()
            };
        }

        private void BindParameters(SqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@username", user.username ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@password", user.password ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uLName", user.uLName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uFName", user.uFName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uMName", user.uMName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uEmail", user.uEmail ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uContactNumber", user.uContactNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uRole", user.uRole ?? (object)DBNull.Value);
        }
    }
}
