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
    public class EquipmentRepository : IEquipmentRepository
    {
        public Equipment getById(int id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipments WHERE equipmentID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return MapToEquipment(reader);
                    }
                }
            }
            return null;
        }

        public IEnumerable<Equipment> getAll()
        {
            var list = new List<Equipment>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipments", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapToEquipment(reader));
                }
            }
            return list;
        }
        public IEnumerable<Equipment> getByName(string name)
        {
            var list = new List<Equipment>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipments WHERE eName LIKE @keyword OR eCategory LIKE @keyword", conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + name + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToEquipment(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Equipment> getByCategory(int categoryID)
        {
            var list = new List<Equipment>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipments WHERE categoryID = @categoryID", conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToEquipment(reader));
                    }
                }
            }
            return list;
        }

        public IEnumerable<Equipment> getByLocation(int locationID)
        {
            var list = new List<Equipment>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Equipments WHERE locationID = @locationID", conn))
                {
                    cmd.Parameters.AddWithValue("@locationID", locationID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapToEquipment(reader));
                    }
                }
            }
            return list;
        }

        public bool add(Equipment entity)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"INSERT INTO Equipments (eName, eDesc, categoryID, locationID, eStatus, eQuantity, ePrice, eCondition) 
                              VALUES (@eName, @eDesc, @categoryID, @locationID, @eStatus, @eQuantity, @ePrice, @eCondition)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    BindParameters(cmd, entity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Equipment entity)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                var query = @"UPDATE Equipments SET eName = @eName, eDesc = @eDesc, categoryID = @categoryID, 
                              locationID = @locationID, eStatus = @eStatus, eQuantity = @eQuantity, 
                              ePrice = @ePrice, eCondition = @eCondition WHERE equipmentID = @equipmentID";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", entity.equipmentID);
                    BindParameters(cmd, entity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateQuantity(int equipmentID, int newQuantity)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Equipments SET eQuantity = @eQuantity WHERE equipmentID = @equipmentID", conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                    cmd.Parameters.AddWithValue("@eQuantity", newQuantity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int equipmentID, string eStatus)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Equipments SET eStatus = @eStatus WHERE equipmentID = @equipmentID", conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                    cmd.Parameters.AddWithValue("@eStatus", eStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Equipments WHERE equipmentID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Equipment MapToEquipment(SqlDataReader reader)
        {
            return new Equipment
            {
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                eName = reader["eName"].ToString(),
                eDesc = reader["eDesc"].ToString(),
                categoryID = Convert.ToInt32(reader["categoryID"]),
                locationID = Convert.ToInt32(reader["locationID"]),
                eStatus = reader["eStatus"].ToString(),
                eQuantity = Convert.ToInt32(reader["eQuantity"]),
                ePrice = Convert.ToDouble(reader["ePrice"]),
                eCondition = reader["eCondition"].ToString()
            };
        }

        private void BindParameters(SqlCommand cmd, Equipment entity)
        {
            cmd.Parameters.AddWithValue("@eName", entity.eName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@eDesc", entity.eDesc ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@categoryID", entity.categoryID);
            cmd.Parameters.AddWithValue("@locationID", entity.locationID);
            cmd.Parameters.AddWithValue("@eStatus", entity.eStatus ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@eQuantity", entity.eQuantity);
            cmd.Parameters.AddWithValue("@ePrice", entity.ePrice);
            cmd.Parameters.AddWithValue("@eCondition", entity.eCondition ?? (object)DBNull.Value);
        }
    }
}
