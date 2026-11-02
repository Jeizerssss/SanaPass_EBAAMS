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
    public class RequestRepository : IRequestRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public RequestRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory
                ?? throw new ArgumentNullException(nameof(connectionFactory));
        }
        public Request getById(int requestID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Requests WHERE requestID = @requestID", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Requests", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Requests WHERE userID = @userID", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Requests WHERE rStatus = @rStatus", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"
                    INSERT INTO Requests
                        (rDate, userID, equipmentID, rLocation, rDesc, rStatus)
                    VALUES
                        (@rDate, @userID, @equipmentID, @rLocation, @rDesc, @rStatus)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rDate", request.rDate);
                    cmd.Parameters.AddWithValue("@userID", request.userID);
                    cmd.Parameters.AddWithValue("@equipmentID", request.equipmentID);
                    cmd.Parameters.AddWithValue(
                        "@rLocation",
                        request.rLocation ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue(
                        "@rDesc",
                        request.rDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue(
                        "@rStatus",
                        request.rStatus ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Request request)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"
                    UPDATE Requests
                    SET rDate = @rDate,
                        userID = @userID,
                        equipmentID = @equipmentID,
                        rLocation = @rLocation,
                        rDesc = @rDesc,
                        rStatus = @rStatus
                    WHERE requestID = @requestID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", request.requestID);
                    cmd.Parameters.AddWithValue("@rDate", request.rDate);
                    cmd.Parameters.AddWithValue("@userID", request.userID);
                    cmd.Parameters.AddWithValue("@equipmentID", request.equipmentID);
                    cmd.Parameters.AddWithValue(
                        "@rLocation",
                        request.rLocation ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue(
                        "@rDesc",
                        request.rDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue(
                        "@rStatus",
                        request.rStatus ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int requestID, string rStatus)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE Requests SET rStatus = @rStatus WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    cmd.Parameters.AddWithValue("@rStatus", rStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int requestID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Requests WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Request MapToRequest(MySqlDataReader reader)
        {
            return new Request
            {
                requestID = Convert.ToInt32(reader["requestID"]),
                rDate = Convert.ToDateTime(reader["rDate"]),
                userID = Convert.ToInt32(reader["userID"]),
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                rLocation = reader["rLocation"] == DBNull.Value
                    ? null
                    : reader["rLocation"].ToString(),
                rDesc = reader["rDesc"] == DBNull.Value
                    ? null
                    : reader["rDesc"].ToString(),
                rStatus = reader["rStatus"] == DBNull.Value
                    ? null
                    : reader["rStatus"].ToString()
            };
        }
    }
}
