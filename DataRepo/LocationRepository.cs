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
        public Location getById(int locationID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Locations WHERE locationID = @locationID", conn))
                {
                    cmd.Parameters.AddWithValue("@locationID", locationID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Location(Convert.ToInt32(reader["locationID"]), reader["lName"].ToString(), reader["lDesc"].ToString(), Convert.ToInt32(reader["lFloorNo"]));
                    }
                }
            }
            return null;
        }

        public Location getByName(string lName)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Locations WHERE lName = @lName", conn))
                {
                    cmd.Parameters.AddWithValue("@lName", lName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Location(Convert.ToInt32(reader["locationID"]), reader["lName"].ToString(), reader["lDesc"].ToString(), Convert.ToInt32(reader["lFloorNo"]));
                    }
                }
            }
            return null;
        }

        public IEnumerable<Location> getAll()
        {
            var list = new List<Location>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM Locations", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(new Location(Convert.ToInt32(reader["locationID"]), reader["lName"].ToString(), reader["lDesc"].ToString(), Convert.ToInt32(reader["lFloorNo"])));
                }
            }
            return list;
        }

        public bool add(Location location)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("INSERT INTO Locations (lName, lDesc, lFloorNo) VALUES (@lName, @lDesc, @lFloorNo)", conn))
                {
                    cmd.Parameters.AddWithValue("@lName", location.lName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lDesc", location.lDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lFloorNo", location.lFloorNo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Location location)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UPDATE Locations SET lName = @lName, lDesc = @lDesc, lFloorNo = @lFloorNo WHERE locationID = @locationID", conn))
                {
                    cmd.Parameters.AddWithValue("@locationID", location.locationID);
                    cmd.Parameters.AddWithValue("@lName", location.lName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lDesc", location.lDesc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lFloorNo", location.lFloorNo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int locationID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
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
