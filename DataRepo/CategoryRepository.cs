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
    public class CategoryRepository : ICategoryRepository
    {
        public Category getById(int categoryID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Categories WHERE categoryID = @categoryID", conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Category(Convert.ToInt32(reader["categoryID"]), reader["cName"].ToString(), reader["cDesc"].ToString());
                    }
                }
            }
            return null;
        }

        public Category getByName(string cName)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Categories WHERE cName = @cName", conn))
                {
                    cmd.Parameters.AddWithValue("@cName", cName);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return new Category(Convert.ToInt32(reader["categoryID"]), reader["cName"].ToString(), reader["cDesc"].ToString());
                    }
                }
            }
            return null;
        }

        public IEnumerable<Category> getAll()
        {
            var list = new List<Category>();
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Categories", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(new Category(Convert.ToInt32(reader["categoryID"]), reader["cName"].ToString(), reader["cDesc"].ToString()));
                }
            }
            return list;
        }

        public bool add(Category category)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("INSERT INTO Categories (cName, cDesc) VALUES (@cName, @cDesc)", conn))
                {
                    cmd.Parameters.AddWithValue("@cName", category.cName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@cDesc", category.cDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool update(Category category)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("UPDATE Categories SET cName = @cName, cDesc = @cDesc WHERE categoryID = @categoryID", conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", category.categoryID);
                    cmd.Parameters.AddWithValue("@cName", category.cName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@cDesc", category.cDesc ?? (object)DBNull.Value);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool delete(int categoryID)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("DELETE FROM Categories WHERE categoryID = @categoryID", conn))
                {
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
