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
    public class TransactionLogRepository : ITransactionLogRepository
    {
        public TransactionLog getById(int transactionLogID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM TransactionLogs WHERE transactionLogID = @transactionLogID", conn))
                {
                    cmd.Parameters.AddWithValue("@transactionLogID", transactionLogID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToTransactionLog(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<TransactionLog> getByRequestId(int requestID)
        {
            var list = new List<TransactionLog>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM TransactionLogs WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToTransactionLog(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<TransactionLog> getByHandledBy(int handledBy)
        {
            var list = new List<TransactionLog>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM TransactionLogs WHERE handledBy = @handledBy", conn))
                {
                    cmd.Parameters.AddWithValue("@handledBy", handledBy);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToTransactionLog(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<TransactionLog> getAll()
        {
            var list = new List<TransactionLog>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM TransactionLogs", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToTransactionLog(reader));
                }
            }
            return list;
        }

        public bool add(TransactionLog log)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO TransactionLogs (date, requestID, handledBy, tlType) 
                              VALUES (@date, @requestID, @handledBy, @tlType)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", log.date);
                    cmd.Parameters.AddWithValue("@requestID", log.requestID);
                    cmd.Parameters.AddWithValue("@handledBy", log.handledBy);
                    cmd.Parameters.AddWithValue("@tlType", log.tlType ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private TransactionLog MapToTransactionLog(MySqlDataReader reader)
        {
            return new TransactionLog
            {
                transactionLogID = Convert.ToInt32(reader["transactionLogID"]),
                date = Convert.ToDateTime(reader["date"]),
                requestID = Convert.ToInt32(reader["requestID"]),
                handledBy = Convert.ToInt32(reader["handledBy"]),
                tlType = reader["tlType"].ToString()
            };
        }
    }
}
