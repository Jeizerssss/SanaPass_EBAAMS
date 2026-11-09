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
    public class LocationRepository : ILocationRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public LocationRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory
                ?? throw new ArgumentNullException(nameof(connectionFactory));
        }
        public Location getById(int locationID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT locationID, lName, lDesc FROM Locations WHERE locationID = @locationID", conn))
                {
                    cmd.Parameters.AddWithValue("@locationID", locationID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Location
                            {
                                locationID = Convert.ToInt32(reader["locationID"]),
                                lName = reader["lName"].ToString(),
                                lDesc = reader["lDesc"].ToString(),
                            };
                    }
                }
            }
            return null;
        }

        public Location getByName(string lName)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Locations WHERE lName = @lName", conn))
                {
                    cmd.Parameters.AddWithValue("@lName", lName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Location
                            {
                                locationID = Convert.ToInt32(reader["locationID"]),
                                lName = reader["lName"].ToString(),
                                lDesc = reader["lDesc"].ToString(),
                            };
                    }
                }
            }
            return null;
        }

        public IEnumerable<Location> getAll()
        {
            var list = new List<Location>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Locations", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(new Location
                        {
                            locationID = Convert.ToInt32(reader["locationID"]),
                            lName = reader["lName"].ToString(),
                            lDesc = reader["lDesc"].ToString(),
                        });
                }
            }
            return list;
        }

        public bool add(Location location)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("INSERT INTO Locations (lName, lDesc) VALUES (@lName, @lDesc)", conn))
                {
                    cmd.Parameters.AddWithValue("@lName", location.lName ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Location location)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();

                const string query = @"
                    UPDATE Locations
                    SET lName = @lName,
                        lDesc = @lDesc,
                        lFloorNo = @lFloorNo
                    WHERE locationID = @locationID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@locationID",
                        location.locationID);

                    cmd.Parameters.AddWithValue(
                        "@lName",
                        location.lName ?? (object)DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@lDesc",
                        location.lDesc ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int locationID)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM Locations WHERE locationID = @locationID", conn))
                {
                    cmd.Parameters.AddWithValue("@locationID", locationID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
