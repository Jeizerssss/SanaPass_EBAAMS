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
    public partial class Maintenance : UserControl
    {
        public Maintenance()
        {
            InitializeComponent();
            SetupMaintenanceGrid();
        }
        private void SetupMaintenanceGrid()
        {
            dgvMaintenance.Columns.Clear();
            dgvMaintenance.AutoGenerateColumns = false;

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "maintenanceID", DataPropertyName = "maintenanceID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "equipmentID", DataPropertyName = "equipmentID", HeaderText = "Equipment ID", Width = 90, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eName", DataPropertyName = "eName", HeaderText = "Equipment Name", Width = 160, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "issueDescription", DataPropertyName = "issueDescription", HeaderText = "Issue / Reason", Width = 200, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "maintenanceDate", DataPropertyName = "maintenanceDate", HeaderText = "Date Logged", Width = 110, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "status", DataPropertyName = "status", HeaderText = "Status", Width = 100, ReadOnly = true });
        }

        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            using (MaintenanceForm addMaintForm = new MaintenanceForm())
            {
                addMaintForm.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = addMaintForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    // LoadMaintenanceData();
                }
            }
        }

        private void btnMaintenanceDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnARefreshEquipment_Click(object sender, EventArgs e)
        {

        }
    }
}
