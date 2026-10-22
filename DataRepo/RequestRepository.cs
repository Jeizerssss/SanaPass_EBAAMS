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
    public class RequestRepository : IRequestRepository
    {
        public Request getById(int requestID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Requests WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToRequest(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Request> getAll()
        {
            var list = new List<Request>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Requests", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToRequest(reader));
                }
            }
            return list;
        }

        public IEnumerable<Request> getByUserId(int userID)
        {
            var list = new List<Request>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Requests WHERE userID = @userID", conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToRequest(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Request> getByStatus(string rStatus)
        {
            var list = new List<Request>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Requests WHERE rStatus = @rStatus", conn))
                {
                    cmd.Parameters.AddWithValue("@rStatus", rStatus);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToRequest(reader));
                    }
                }
            }
            return list;
        }

        public bool add(Request request)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Requests (date, userID, equipmentID, rDesc, rStatus) 
                              VALUES (@date, @userID, @equipmentID, @rDesc, @rStatus)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", request.date);
                    cmd.Parameters.AddWithValue("@userID", request.userID);
                    cmd.Parameters.AddWithValue("@equipmentID", request.equipmentID);
                    cmd.Parameters.AddWithValue("@rDesc", request.rDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@rStatus", request.rStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Request request)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Requests SET date = @date, userID = @userID, equipmentID = @equipmentID, 
                              rDesc = @rDesc, rStatus = @rStatus WHERE requestID = @requestID";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", request.requestID);
                    cmd.Parameters.AddWithValue("@date", request.date);
                    cmd.Parameters.AddWithValue("@userID", request.userID);
                    cmd.Parameters.AddWithValue("@equipmentID", request.equipmentID);
                    cmd.Parameters.AddWithValue("@rDesc", request.rDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@rStatus", request.rStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int requestID, string rStatus)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Requests SET rStatus = @rStatus WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.Parameters.AddWithValue("@rStatus", rStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int requestID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Requests WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Request MapToRequest(SqlDataReader reader)
        {
            return new Request
            {
                requestID = Convert.ToInt32(reader["requestID"]),
                date = Convert.ToDateTime(reader["date"]),
                userID = Convert.ToInt32(reader["userID"]),
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                rDesc = reader["rDesc"].ToString(),
                rStatus = reader["rStatus"].ToString()
            };
        }
    }
}
