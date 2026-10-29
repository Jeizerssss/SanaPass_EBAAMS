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
    public partial class Equipments : UserControl
    {
        public Equipments()
        {
            InitializeComponent();
        }

        private void Equipments_Load(object sender, EventArgs e)
        {
            SetupEquipmentGrid();
            // TODO: LoadEquipmentData(); once XAMPP/MySQL connection is active
        }

        private void SetupEquipmentGrid()
        {
            dgvAEquipments.Columns.Clear();
            dgvAEquipments.AutoGenerateColumns = false;

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "equipmentID", DataPropertyName = "equipmentID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eName", DataPropertyName = "eName", HeaderText = "Equipment Name", Width = 180, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eDesc", DataPropertyName = "eDesc", HeaderText = "Description", Width = 200, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "categoryID", DataPropertyName = "categoryID", HeaderText = "Category ID", Width = 90, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "locationID", DataPropertyName = "locationID", HeaderText = "Location ID", Width = 90, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eQuantity", DataPropertyName = "eQuantity", HeaderText = "Quantity", Width = 80, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "ePrice", DataPropertyName = "ePrice", HeaderText = "Price", Width = 90, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eCondition", DataPropertyName = "eCondition", HeaderText = "Condition", Width = 100, ReadOnly = true });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eStatus", DataPropertyName = "eStatus", HeaderText = "Status", Width = 100, ReadOnly = true });
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvAEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment item first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedId = Convert.ToInt32(dgvAEquipments.SelectedRows[0].Cells["equipmentID"].Value);

            using (EquipmentDetailsForm detailsForm = new EquipmentDetailsForm(selectedId))
            {
                detailsForm.StartPosition = FormStartPosition.CenterParent;
                detailsForm.ShowDialog(this);

                // If changes were made, reload the grid
                if (detailsForm.DataChanged)
                {
                    // LoadEquipmentData();
                }
            }
        }

        private void btnAEquipmentDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {

        }

        private void btnARefreshEquipment_Click(object sender, EventArgs e)
        {

        }

        private void btnCatAndLoc_Click(object sender, EventArgs e)
        {
            using (CatAndLocForm catLocForm = new CatAndLocForm())
            {
                catLocForm.StartPosition = FormStartPosition.CenterParent;
                catLocForm.ShowDialog(this);

                // Optional: If categories or locations were modified, you can refresh your dropdown filters or grid data here
                // LoadEquipmentData();
            }
        }
    }
}
