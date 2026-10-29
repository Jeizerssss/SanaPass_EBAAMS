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
        public Maintenance getById(int mID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenances WHERE mID = @mID", conn))
                {
                    cmd.Parameters.AddWithValue("@mID", mID);
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
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenances WHERE equipmentID = @equipmentID", conn))
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
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenances WHERE mStatus = @mStatus", conn))
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
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Maintenances", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToMaintenance(reader));
                }
            }
            return list;
        }

        public bool add(Maintenance maintenance)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Maintenances (date, equipmentID, mStatus, mDesc) 
                              VALUES (@date, @equipmentID, @mStatus, @mDesc)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", maintenance.date);
                    cmd.Parameters.AddWithValue("@equipmentID", maintenance.equipmentID);
                    cmd.Parameters.AddWithValue("@mStatus", maintenance.mStatus ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@mDesc", maintenance.mDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Maintenance maintenance)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Maintenances SET date = @date, equipmentID = @equipmentID, 
                              mStatus = @mStatus, mDesc = @mDesc WHERE mID = @mID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mID", maintenance.mID);
                    cmd.Parameters.AddWithValue("@date", maintenance.date);
                    cmd.Parameters.AddWithValue("@equipmentID", maintenance.equipmentID);
                    cmd.Parameters.AddWithValue("@mStatus", maintenance.mStatus ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@mDesc", maintenance.mDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int mID, string mStatus)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE Maintenances SET mStatus = @mStatus WHERE mID = @mID", conn))
                {
                    cmd.Parameters.AddWithValue("@mID", mID);
                    cmd.Parameters.AddWithValue("@mStatus", mStatus);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int mID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Maintenances WHERE mID = @mID", conn))
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
                mID = Convert.ToInt32(reader["mID"]),
                date = Convert.ToDateTime(reader["date"]),
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                mStatus = reader["mStatus"].ToString(),
                mDesc = reader["mDesc"].ToString()
            };
        }
    }
}
