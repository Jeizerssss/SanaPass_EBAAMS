using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Services;

namespace SanaPass_EBAAMS.Forms
{
    public partial class Maintenance : UserControl
    {
        private readonly IMaintenanceRepository _maintenanceRepository = new MaintenanceRepository();
        private readonly IEquipmentService _equipmentService = new EquipmentService(
            new EquipmentRepository(new MySqlConnectionFactory()));
        private List<SanaPass_EBAAMS.Models.Maintenance> _records =
            new List<SanaPass_EBAAMS.Models.Maintenance>();

        public Maintenance()
        {
            InitializeComponent();
            SetupMaintenanceGrid();
            btnAddMaintenance.Click += btnAddMaintenance_Click;
            btnMaintenanceDetails.Click += btnMaintenanceDetails_Click;
            btnARefreshMaintenance.Click += btnARefreshEquipment_Click;
            txtBoxAMaintenanceSearch.TextChanged += txtBoxAMaintenanceSearch_TextChanged;
            cmbAMaintenanceFilter.SelectedIndexChanged += txtBoxAMaintenanceSearch_TextChanged;
            cmbAMaintenanceFilter.Items.AddRange(new object[] { "All Status", "Under Maintenance", "In Progress", "Completed" });
            cmbAMaintenanceFilter.SelectedIndex = 0;
            LoadMaintenanceData();
        }
        private void SetupMaintenanceGrid()
        {
            dgvMaintenance.Columns.Clear();
            dgvMaintenance.AutoGenerateColumns = false;
            dgvMaintenance.ReadOnly = true;
            dgvMaintenance.AllowUserToAddRows = false;
            dgvMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaintenance.MultiSelect = false;

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "maintenanceID", DataPropertyName = "maintenanceID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "equipmentID", DataPropertyName = "equipmentID", HeaderText = "Equipment ID", Width = 90, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "mDate", DataPropertyName = "mDate", HeaderText = "Date Logged", Width = 140, ReadOnly = true, DefaultCellStyle = { Format = "yyyy-MM-dd" } });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "mDesc", DataPropertyName = "mDesc", HeaderText = "Issue / Reason", Width = 300, ReadOnly = true });

            dgvMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "mStatus", DataPropertyName = "mStatus", HeaderText = "Status", Width = 140, ReadOnly = true });
        }

        private void btnAddMaintenance_Click(object sender, EventArgs e)
        {
            using (MaintenanceForm addMaintForm = new MaintenanceForm(_maintenanceRepository, _equipmentService))
            {
                addMaintForm.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = addMaintForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadMaintenanceData();
                }
            }
        }

        private void btnMaintenanceDetails_Click(object sender, EventArgs e)
        {
            var record = dgvMaintenance.CurrentRow?.DataBoundItem as SanaPass_EBAAMS.Models.Maintenance;
            if (record == null)
            {
                MessageBox.Show("Select a maintenance record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Maintenance #{record.maintenanceID}\nEquipment ID: {record.equipmentID}\nDate: {record.mDate:g}\n" +
                $"Status: {record.mStatus}\nDescription: {record.mDesc}",
                "Maintenance Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnARefreshEquipment_Click(object sender, EventArgs e)
        {
            LoadMaintenanceData();
        }

        private void LoadMaintenanceData()
        {
            try
            {
                _records = _maintenanceRepository.getAll().ToList();
                lblATotalMaintenance.Text = _records.Count.ToString();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load maintenance records: {ex.Message}", "Maintenance Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            if (dgvMaintenance == null) return;
            string search = txtBoxAMaintenanceSearch.Text.Trim();
            if (search == "Enter search") search = string.Empty;
            string status = cmbAMaintenanceFilter.SelectedItem as string;

            dgvMaintenance.DataSource = _records.Where(record =>
                (string.IsNullOrEmpty(search) || record.maintenanceID.ToString().Contains(search) ||
                 record.equipmentID.ToString().Contains(search) ||
                 (record.mDesc ?? string.Empty).IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(status) || status == "All Status" || record.mStatus == status))
                .ToList();
        }

        private void txtBoxAMaintenanceSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
