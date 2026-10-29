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
    public class PaymentHistoryRepository : IPaymentHistoryRepository
    {
        public PaymentHistory getById(int pHID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM PaymentHistories WHERE pHID = @pHID", conn))
                {
                    cmd.Parameters.AddWithValue("@pHID", pHID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToPaymentHistory(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<PaymentHistory> getByRequestId(int requestID)
        {
            var list = new List<PaymentHistory>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM PaymentHistories WHERE requestID = @requestID", conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", requestID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToPaymentHistory(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<PaymentHistory> getAll()
        {
            var list = new List<PaymentHistory>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM PaymentHistories", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToPaymentHistory(reader));
                }
            }
            return list;
        }

        public bool add(PaymentHistory paymentHistory)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO PaymentHistories (requestID, pType, amountReceived, remainingBalance) 
                              VALUES (@requestID, @pType, @amountReceived, @remainingBalance)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@requestID", paymentHistory.requestID);
                    cmd.Parameters.AddWithValue("@pType", paymentHistory.pType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@amountReceived", paymentHistory.amountReceived);
                    cmd.Parameters.AddWithValue("@remainingBalance", paymentHistory.remainingBalance);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private PaymentHistory MapToPaymentHistory(MySqlDataReader reader)
        {
            return new PaymentHistory
            {
                pHID = Convert.ToInt32(reader["pHID"]),
                requestID = Convert.ToInt32(reader["requestID"]),
                pType = reader["pType"].ToString(),
                amountReceived = Convert.ToDouble(reader["amountReceived"]),
                remainingBalance = Convert.ToDouble(reader["remainingBalance"])
            };
        }
    }
}
