using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS
{
    public partial class MaintenanceForm : Form
    {
        private IMaintenanceRepository _maintenanceRepository;
        private IEquipmentService _equipmentService;
        private ComboBox cmbEquipment;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;

        public MaintenanceForm()
        {
            InitializeComponent();
            InitializeFormControls();
        }

        public MaintenanceForm(
            IMaintenanceRepository maintenanceRepository,
            IEquipmentService equipmentService) : this()
        {
            _maintenanceRepository = maintenanceRepository
                ?? throw new ArgumentNullException(nameof(maintenanceRepository));
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));
            LoadEquipment();
        }

        public bool DataChanged { get; private set; }

        private void InitializeFormControls()
        {
            Text = "Add Maintenance Record";
            ClientSize = new System.Drawing.Size(520, 360);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(18),
                ColumnCount = 2,
                RowCount = 5
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            cmbEquipment = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };
            dtpDate = new DateTimePicker { Dock = DockStyle.Fill, Format = DateTimePickerFormat.Short, Value = DateTime.Today };
            cmbStatus = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbStatus.Items.AddRange(new object[] { "Under Maintenance", "In Progress", "Completed" });
            cmbStatus.SelectedIndex = 0;
            txtDescription = new TextBox { Dock = DockStyle.Fill, Multiline = true, Height = 90 };
            btnSave = new Button { Text = "Save", AutoSize = true };
            btnCancel = new Button { Text = "Cancel", AutoSize = true, DialogResult = DialogResult.Cancel };
            btnSave.Click += btnSave_Click;
            btnCancel.Click += (sender, e) => Close();

            AddRow(layout, 0, "Equipment", cmbEquipment);
            AddRow(layout, 1, "Date", dtpDate);
            AddRow(layout, 2, "Status", cmbStatus);
            AddRow(layout, 3, "Description", txtDescription);

            var buttons = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft
            };
            buttons.Controls.Add(btnCancel);
            buttons.Controls.Add(btnSave);
            layout.Controls.Add(buttons, 1, 4);
            Controls.Add(layout);
            AcceptButton = btnSave;
            CancelButton = btnCancel;
        }

        private static void AddRow(TableLayoutPanel layout, int row, string label, Control control)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layout.Controls.Add(new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left }, 0, row);
            layout.Controls.Add(control, 1, row);
        }

        private void LoadEquipment()
        {
            try
            {
                cmbEquipment.DataSource = _equipmentService.getAllEquipment()
                    .Where(equipment => string.Equals(equipment.eStatus, "Available", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                cmbEquipment.DisplayMember = "eName";
                cmbEquipment.ValueMember = "equipmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load equipment: {ex.Message}", "Maintenance Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_maintenanceRepository == null || _equipmentService == null)
            {
                MessageBox.Show("Maintenance services are unavailable.", "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbEquipment.SelectedValue == null || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Select equipment and enter a description.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool saved = _maintenanceRepository.add(new Maintenance
                {
                    equipmentID = Convert.ToInt32(cmbEquipment.SelectedValue),
                    mDate = dtpDate.Value.Date,
                    mStatus = cmbStatus.SelectedItem.ToString(),
                    mDesc = txtDescription.Text.Trim()
                });

                if (!saved)
                {
                    MessageBox.Show("The maintenance record was not saved.", "Save Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataChanged = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save maintenance record: {ex.Message}", "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
