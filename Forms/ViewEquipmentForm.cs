using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SanaPass_EBAAMS.DataRepo;

namespace SanaPass_EBAAMS.Forms
{
    public partial class ViewEquipmentForm : Form
    {
        private readonly int _equipmentID;
        public bool DataChanged { get; set; } = false;

        public ViewEquipmentForm()
        {
            InitializeComponent();
        }

        public ViewEquipmentForm(int equipmentID) : this()
        {
            _equipmentID = equipmentID;
            LoadEquipmentDetails(_equipmentID);
        }

        private void LoadEquipmentDetails(int id)
        {
            try
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();
                    string query = @"SELECT e.*, c.categoryName, l.locationName 
                                     FROM equipments e 
                                     LEFT JOIN categories c ON e.categoryID = c.categoryID 
                                     LEFT JOIN locations l ON e.locationID = l.locationID 
                                     WHERE e.equipmentID = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Map database fields to your specific Label controls
                                txtEquipmentID.Text = reader["equipmentID"].ToString();
                                textName.Text = reader["eName"].ToString(); // Assuming label1 is the equipment name heading/display
                                textEquipmentDescription.Text = reader["eDesc"].ToString();
                                textCategory.Text = reader["categoryName"] != DBNull.Value ? reader["categoryName"].ToString() : reader["categoryID"].ToString();
                                textLocation.Text = reader["locationName"] != DBNull.Value ? reader["locationName"].ToString() : reader["locationID"].ToString();
                                textStatus.Text = reader["eStatus"].ToString();
                                textCondition.Text = reader["eCondition"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading equipment details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Optional: Open an edit dialog or enable editing mode
            // For now, you can trigger a signal or handle updates here
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this equipment item?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DbConnectionFactory.CreateConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM equipments WHERE equipmentID = @id";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", _equipmentID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    DataChanged = true; // Signals Equipments.cs to refresh grid
                    MessageBox.Show("Equipment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting equipment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}