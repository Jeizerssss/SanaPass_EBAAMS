using MySql.Data.MySqlClient;
using SanaPass_EBAAMS.DataRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class AddEquipmentForm : Form
    {
        public AddEquipmentForm()
        {
            InitializeComponent();
        }
        public bool DataChanged { get; set; } = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Equipment name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO equipments (eName, eDesc, categoryID, locationID, eStatus, eQuantity, ePrice, eCondition) 
                             VALUES (@eName, @eDesc, @categoryID, @locationID, @eStatus, @eQuantity, @ePrice, @eCondition)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eName", textBoxName.Text.Trim());
                        cmd.Parameters.AddWithValue("@eDesc", textBoxEquipmentDescription.Text.Trim());

                        // Assuming your combo boxes hold IDs or text values
                        cmd.Parameters.AddWithValue("@categoryID", comboBoxCategory.SelectedValue ?? 1); // fallback ID if needed
                        cmd.Parameters.AddWithValue("@locationID", comboBoxLocation.SelectedValue ?? 1);
                        cmd.Parameters.AddWithValue("@eStatus", comboBoxStatus.Text.Trim());

                        // Default quantity/price/condition values if fields aren't on the form yet
                        cmd.Parameters.AddWithValue("@eQuantity", 1);
                        cmd.Parameters.AddWithValue("@ePrice", 0.00);
                        cmd.Parameters.AddWithValue("@eCondition", "Good"); // or map from your condition combobox/comboBox1


                        cmd.ExecuteNonQuery();
                    }
                }

                // 2. Mark data as changed so the grid refreshes when this form closes
                DataChanged = true;

                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving equipment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
