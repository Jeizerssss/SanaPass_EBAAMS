using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.DataRepo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee getById(int employeeID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"SELECT e.*, u.username, u.password, u.uLName, u.uFName, u.uMName, u.uEmail, u.uContactNumber, u.uRole 
                              FROM Employees e 
                              INNER JOIN Users u ON e.userID = u.userID 
                              WHERE e.employeeID = @employeeID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToEmployee(reader);
                    }
                }
            }
            return null;
        }

        public Employee getByUserId(int userID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"SELECT e.*, u.username, u.password, u.uLName, u.uFName, u.uMName, u.uEmail, u.uContactNumber, u.uRole 
                              FROM Employees e 
                              INNER JOIN Users u ON e.userID = u.userID 
                              WHERE e.userID = @userID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToEmployee(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Employee> getAll()
        {
            var list = new List<Employee>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"SELECT e.*, u.username, u.password, u.uLName, u.uFName, u.uMName, u.uEmail, u.uContactNumber, u.uRole 
                              FROM Employees e 
                              INNER JOIN Users u ON e.userID = u.userID";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToEmployee(reader));
                }
            }
            return list;
        }

        public bool add(Employee employee)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = "INSERT INTO Employees (userID, position) VALUES (@userID, @position)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", employee.userID);
                    cmd.Parameters.AddWithValue("@position", employee.position ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Employee employee)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = "UPDATE Employees SET userID = @userID, position = @position WHERE employeeID = @employeeID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employee.employeeID);
                    cmd.Parameters.AddWithValue("@userID", employee.userID);
                    cmd.Parameters.AddWithValue("@position", employee.position ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int employeeID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Employees WHERE employeeID = @employeeID", conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Employee MapToEmployee(MySqlDataReader reader)
        {
            var emp = new Employee
            {
                employeeID = Convert.ToInt32(reader["employeeID"]),
                userID = Convert.ToInt32(reader["userID"]),
                position = reader["position"].ToString(),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                uLName = reader["uLName"].ToString(),
                uFName = reader["uFName"].ToString(),
                uMName = reader["uMName"].ToString(),
                uEmail = reader["uEmail"].ToString(),
                uContactNumber = reader["uContactNumber"].ToString(),
                uRole = reader["uRole"].ToString()
            };
            return emp;
        }
    }
}
