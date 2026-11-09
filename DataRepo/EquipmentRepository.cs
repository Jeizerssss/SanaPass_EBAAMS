using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace SanaPass_EBAAMS.DataRepo
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public EquipmentRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory
                ?? throw new ArgumentNullException(nameof(connectionFactory));
        }

        public Equipment getById(int id)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(
                    "SELECT * FROM Equipments WHERE equipmentID = @id",
                    conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapToEquipment(reader);
                        }
                    }
                }
            }

            return null;
        }

        public IEnumerable<Equipment> getAll()
        {
            var list = new List<Equipment>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Equipments", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                // Updated to match your schema columns (eName, eDesc)
                string query = @"SELECT e.* FROM Equipments e 
                                 LEFT JOIN Categories c ON e.categoryID = c.categoryID 
                                 WHERE e.eName LIKE @keyword OR e.eDesc LIKE @keyword OR c.cName LIKE @keyword";

                using (var cmd = new MySqlCommand(query, conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Equipments WHERE categoryID = @categoryID", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Equipments WHERE locationID = @locationID", conn))
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
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    INSERT INTO Equipments
                        (eName, eDesc, categoryID, locationID, eStatus, eCondition)
                    VALUES
                        (@eName, @eDesc, @categoryID, @locationID, @eStatus, @eCondition)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    BindParameters(cmd, entity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Equipment entity)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    UPDATE Equipments
                    SET eName = @eName,
                        eDesc = @eDesc,
                        categoryID = @categoryID,
                        locationID = @locationID,
                        eStatus = @eStatus,
                        eCondition = @eCondition
                    WHERE equipmentID = @equipmentID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@equipmentID",
                        entity.equipmentID);

                    BindParameters(cmd, entity);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateStatus(int equipmentID, string eStatus)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE Equipments SET eStatus = @eStatus WHERE equipmentID = @equipmentID", conn))
                {
                    cmd.Parameters.AddWithValue("@equipmentID", equipmentID);
                    cmd.Parameters.AddWithValue("@eStatus", eStatus ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int id)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Equipments WHERE equipmentID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Equipment MapToEquipment(IDataReader reader) // Using IDataReader for flexibility
        {
            return new Equipment
            {
                equipmentID = Convert.ToInt32(reader["equipmentID"]),
                eName = reader["eName"].ToString(),
                eDesc = reader["eDesc"]?.ToString(),
                categoryID = Convert.ToInt32(reader["categoryID"]),
                locationID = Convert.ToInt32(reader["locationID"]),
                eStatus = reader["eStatus"].ToString(),
                eCondition = reader["eCondition"].ToString()
            };
        }

        private void BindParameters(MySqlCommand cmd, Equipment entity)
        {
            cmd.Parameters.AddWithValue("@eName", entity.eName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@eDesc", entity.eDesc ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@categoryID", entity.categoryID);
            cmd.Parameters.AddWithValue("@locationID", entity.locationID);
            cmd.Parameters.AddWithValue("@eStatus", entity.eStatus ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@eCondition", entity.eCondition ?? (object)DBNull.Value);
        }
    }
}