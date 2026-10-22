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
    public class FineRepository : IFineRepository
    {
        public Fine getById(int fineID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Fines WHERE fineID = @fineID", conn))
                {
                    cmd.Parameters.AddWithValue("@fineID", fineID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToFine(reader);
                    }
                }
            }
            return null;
        }

        public Fine getByRequestId(int requestID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Fines WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToFine(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Fine> getAll()
        {
            var list = new List<Fine>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Fines", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToFine(reader));
                }
            }
            return list;
        }

        public IEnumerable<Fine> getByStatus(string fineStatus)
        {
            var list = new List<Fine>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Fines WHERE fineStatus = @fineStatus", conn))
                {
                    cmd.Parameters.AddWithValue("@fineStatus", fineStatus);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToFine(reader));
                    }
                }
            }
            return list;
        }

        public bool add(Fine fine)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Fines (date, requestID, amount, fineStatus) 
                              VALUES (@date, @requestID, @amount, @fineStatus)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", fine.date);
                    cmd.Parameters.AddWithValue("@requestID", fine.requestID);
                    cmd.Parameters.AddWithValue("@amount", fine.amount);
                    cmd.Parameters.AddWithValue("@fineStatus", fine.fineStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Fine fine)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Fines SET date = @date, requestID = @requestID, 
                              amount = @amount, fineStatus = @fineStatus WHERE fineID = @fineID";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fineID", fine.fineID);
                    cmd.Parameters.AddWithValue("@date", fine.date);
                    cmd.Parameters.AddWithValue("@requestID", fine.requestID);
                    cmd.Parameters.AddWithValue("@amount", fine.amount);
                    cmd.Parameters.AddWithValue("@fineStatus", fine.fineStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int fineID, string fineStatus)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Fines SET fineStatus = @fineStatus WHERE fineID = @fineID", conn))
                {
                    cmd.Parameters.AddWithValue("@fineID", fineID);
                    cmd.Parameters.AddWithValue("@fineStatus", fineStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int fineID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Fines WHERE fineID = @fineID", conn))
                {
                    cmd.Parameters.AddWithValue("@fineID", fineID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Fine MapToFine(SqlDataReader reader)
        {
            return new Fine
            {
                fineID = Convert.ToInt32(reader["fineID"]),
                date = Convert.ToDateTime(reader["date"]),
                requestID = Convert.ToInt32(reader["requestID"]),
                amount = Convert.ToDouble(reader["amount"]),
                fineStatus = reader["fineStatus"].ToString()
            };
        }
    }
}
