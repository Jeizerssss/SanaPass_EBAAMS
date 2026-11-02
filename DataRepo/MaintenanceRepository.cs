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
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public MaintenanceRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory
                ?? throw new ArgumentNullException(nameof(connectionFactory));
        }
        public Maintenance getById(int maintenanceID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenance WHERE maintenanceID = @maintenanceID", conn))
                {
                    cmd.Parameters.AddWithValue("@maintenanceID", maintenanceID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToMaintenance(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Maintenance> getByEquipmentId(int equipmentID)
        {
            var list = new List<Maintenance>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenance WHERE equipmentID = @equipmentID", conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToMaintenance(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Maintenance> getByStatus(string mStatus)
        {
            var list = new List<Maintenance>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenance WHERE mStatus = @mStatus", conn))
                {
                    cmd.Parameters.AddWithValue("@mStatus", mStatus);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToMaintenance(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Maintenance> getAll()
        {
            var list = new List<Maintenance>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenance", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToMaintenance(reader));
                }
            }
            return list;
        }

        public bool add(Maintenance maintenance)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Maintenance
                              (mDate, equipmentID, mStatus, mDesc)
                              VALUES
                              (@mDate, @equipmentID, @mStatus, @mDesc)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mDate", maintenance.mDate);
                    cmd.Parameters.AddWithValue("@equipmentID", maintenance.equipmentID);
                    cmd.Parameters.AddWithValue("@mStatus", maintenance.mStatus ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@mDesc", maintenance.mDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Maintenance maintenance)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Maintenance
                              SET mDate = @mDate,
                                  equipmentID = @equipmentID,
                                  mStatus = @mStatus,
                                  mDesc = @mDesc
                              WHERE maintenanceID = @maintenanceID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maintenanceID", maintenance.maintenanceID);
                    cmd.Parameters.AddWithValue("@mDate", maintenance.mDate);
                    cmd.Parameters.AddWithValue("@equipmentID", maintenance.equipmentID);
                    cmd.Parameters.AddWithValue("@mStatus", maintenance.mStatus ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@mDesc", maintenance.mDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int mID, string mStatus)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE Maintenance SET mStatus = @mStatus WHERE maintenanceID = @mID", conn))
                {
                    cmd.Parameters.AddWithValue("@mID", mID);
                    cmd.Parameters.AddWithValue("@mStatus", mStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int mID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Maintenance WHERE maintenanceID = @mID", conn))
                {
                    cmd.Parameters.AddWithValue("@mID", mID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Maintenance MapToMaintenance(MySqlDataReader reader)
        {
            return new Maintenance
            {
                maintenanceID = Convert.ToInt32(reader["maintenanceID"]),
                mDate = Convert.ToDateTime(reader["mDate"]),
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                mStatus = reader["mStatus"].ToString(),
                mDesc = reader["mDesc"].ToString()
            };
        }
    }
}
