using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SanaPass_EBAAMS.DataRepo
{
    public class PaymentHistoryRepository : IPaymentHistoryRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public PaymentHistory getById(int paymentHistoriesID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    SELECT paymentHistoriesID, pDate, userID, pHType,
                           accountBalance, amountReceived, remainingBalance
                    FROM PaymentHistories
                    WHERE paymentHistoriesID = @paymentHistoriesID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@paymentHistoriesID", paymentHistoriesID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapToPaymentHistory(reader);
                        }
                    }
                }
            }

            return null;
        }

        public IEnumerable<PaymentHistory> getByUserId(int userID)
        {
            var list = new List<PaymentHistory>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    SELECT paymentHistoriesID, pDate, userID, pHType,
                           accountBalance, amountReceived, remainingBalance
                    FROM PaymentHistories
                    WHERE userID = @userID
                    ORDER BY pDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapToPaymentHistory(reader));
                        }
                    }
                }
            }

            return list;
        }

        public IEnumerable<PaymentHistory> getAll()
        {
            var list = new List<PaymentHistory>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    SELECT paymentHistoriesID, pDate, userID, pHType,
                           accountBalance, amountReceived, remainingBalance
                    FROM PaymentHistories
                    ORDER BY pDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(MapToPaymentHistory(reader));
                    }
                }
            }

            return list;
        }

        public bool add(PaymentHistory paymentHistory)
        {
            if (paymentHistory == null)
            {
                return false;
            }

            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    INSERT INTO PaymentHistories
                        (pDate, userID, pHType, accountBalance,
                         amountReceived, remainingBalance)
                    VALUES
                        (@pDate, @userID, @pHType, @accountBalance,
                         @amountReceived, @remainingBalance)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pDate", paymentHistory.pDate);
                    cmd.Parameters.AddWithValue("@userID", paymentHistory.userID);
                    cmd.Parameters.AddWithValue("@pHType",
                        paymentHistory.pHType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@accountBalance",
                        paymentHistory.accountBalance);
                    cmd.Parameters.AddWithValue("@amountReceived",
                        paymentHistory.amountReceived);
                    cmd.Parameters.AddWithValue("@remainingBalance",
                        paymentHistory.remainingBalance);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private PaymentHistory MapToPaymentHistory(MySqlDataReader reader)
        {
            return new PaymentHistory
            {
                paymentHistoriesID = Convert.ToInt32(reader["paymentHistoriesID"]),
                pDate = Convert.ToDateTime(reader["pDate"]),
                userID = Convert.ToInt32(reader["userID"]),
                pHType = reader["pHType"].ToString(),
                accountBalance = Convert.ToDouble(reader["accountBalance"]),
                amountReceived = Convert.ToDouble(reader["amountReceived"]),
                remainingBalance = Convert.ToDouble(reader["remainingBalance"])
            };
        }
    }
}
