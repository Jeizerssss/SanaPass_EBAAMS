using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Helpers; 
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
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
                var cmd = new MySqlCommand("SELECT * FROM Users WHERE userID = @userID", conn);
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
                var cmd = new MySqlCommand("SELECT * FROM Users WHERE username = @username", conn);
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

        public User validateLogin(string username, string plainPassword)
        {
            // 1. Fetch user by username first
            var user = getByUsername(username);
            if (user != null)
            {
                // 2. Verify the plain-text password against the stored BCrypt hash
                bool isPasswordValid = PasswordHelper.VerifyPassword(plainPassword, user.password);
                if (isPasswordValid)
                {
                    return user; // Login successful!
                }
            }
            return null; // Login failed
        }

        public IEnumerable<User> getAll()
        {
            var users = new List<User>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Users", conn);
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

        public string GetEmployeeRole(int userID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                string query = "SELECT ePosition FROM employees WHERE userID = @userID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
        }
        public bool add(User user)
        {
            if (!string.IsNullOrEmpty(user.password))
            {
                user.password = PasswordHelper.HashPassword(user.password);
            }

            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                // Match exact column names from your database schema
                var query = @"INSERT INTO Users (username, uPassword, uLName, uFName, uMName, email, contactNo, uRole) 
                              VALUES (@username, @password, @uLName, @uFName, @uMName, @uEmail, @uContactNumber, @uRole)";
                var cmd = new MySqlCommand(query, conn);
                BindParameters(cmd, user);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool update(User user)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Users SET username = @username, uPassword = @password, uLName = @uLName, 
                              uFName = @uFName, uMName = @uMName, email = @uEmail, contactNo = @uContactNumber, 
                              uRole = @uRole WHERE userID = @userID";
                var cmd = new MySqlCommand(query, conn);
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
                var cmd = new MySqlCommand("DELETE FROM Users WHERE userID = @userID", conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private User MapToUser(MySqlDataReader reader)
        {
            return new User
            {
                userID = Convert.ToInt32(reader["userID"]),
                username = reader["username"].ToString(),
                password = reader["uPassword"].ToString(),      
                uLName = reader["uLName"].ToString(),
                uFName = reader["uFName"].ToString(),
                uMName = reader["uMName"].ToString(),
                uEmail = reader["email"].ToString(),            
                uContactNumber = reader["contactNo"].ToString(),
                uRole = reader["uRole"].ToString()
            };
        }
        public bool LinkOrCreateEmployeeForUser(int userID, string position, string department, DateTime hireDate)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE userID = @userID";
                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userID", userID);
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return true; 
                    }
                }

                
                string insertQuery = @"INSERT INTO Employees (userID, position) 
                              VALUES (@userID, @position)";

                using (var insertCmd = new MySqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@userID", userID);
                    insertCmd.Parameters.AddWithValue("@position", position ?? (object)DBNull.Value);

                    return insertCmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private void BindParameters(MySqlCommand cmd, User user)
        {
            cmd.Parameters.AddWithValue("@username", user.username ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uPassword", user.password ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uLName", user.uLName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uFName", user.uFName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uMName", user.uMName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@email", user.uEmail ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@contactNo", user.uContactNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@uRole", user.uRole ?? (object)DBNull.Value);
        }
    }
}