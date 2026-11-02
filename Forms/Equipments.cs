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
using SanaPass_EBAAMS.Interfaces;

namespace SanaPass_EBAAMS.Forms
{
    public partial class Equipments : UserControl
    {
        private readonly IEquipmentService _equipmentService;

        public Equipments()
        {
            InitializeComponent();
        }

        public Equipments(IEquipmentService equipmentService)
            : this()
        {
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));
        }

        private void Equipments_Load(object sender, EventArgs e)
        {
            SetupEquipmentGrid();
            LoadEquipmentData();
        }

        private void SetupEquipmentGrid()
        {
            dgvAEquipments.Columns.Clear();
            dgvAEquipments.AutoGenerateColumns = false;

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "equipmentID",
                DataPropertyName = "equipmentID",
                HeaderText = "ID",
                Visible = false
            });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eName",
                DataPropertyName = "eName",
                HeaderText = "Equipment Name",
                Width = 220,
                ReadOnly = true
            });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eStatus",
                DataPropertyName = "eStatus",
                HeaderText = "Status",
                Width = 120,
                ReadOnly = true
            });

            dgvAEquipments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eCondition",
                DataPropertyName = "eCondition",
                HeaderText = "Condition",
                Width = 110,
                ReadOnly = true
            });
        }

        public void LoadEquipmentData()
        {
            if (_equipmentService == null)
            {
                return;
            }

            try
            {
                dgvAEquipments.DataSource =
                    _equipmentService.getAllEquipment().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load equipment data: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAEquipmentDetails_Click(object sender, EventArgs e)
        {
            if (dgvAEquipments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an equipment item first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedId = Convert.ToInt32(dgvAEquipments.SelectedRows[0].Cells["equipmentID"].Value);

            using (ViewEquipmentForm detailsForm = new ViewEquipmentForm(selectedId))
            {
                detailsForm.StartPosition = FormStartPosition.CenterParent;
                detailsForm.ShowDialog(this);

                if (detailsForm.DataChanged)
                {
                    LoadEquipmentData();
                }
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            using (AddEquipmentForm addForm = new AddEquipmentForm())
            {
                addForm.StartPosition = FormStartPosition.CenterParent;
                addForm.ShowDialog(this);

                if (addForm.DataChanged)
                {
                    LoadEquipmentData();
                }
            }
        }

        private void btnARefreshEquipment_Click(object sender, EventArgs e)
        {
            LoadEquipmentData();
        }

        private void btnCatAndLoc_Click(object sender, EventArgs e)
        {
           
        }
    }
}