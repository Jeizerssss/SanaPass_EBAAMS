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
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS.Forms
{
    public partial class ViewEquipmentForm : Form
    {
        private readonly int _equipmentID;
        private readonly IEquipmentService _equipmentService;
        public bool DataChanged { get; set; } = false;

        public ViewEquipmentForm()
        {
            InitializeComponent();
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
        }

        public ViewEquipmentForm(
            int equipmentID,
            IEquipmentService equipmentService)
            : this()
        {
            _equipmentID = equipmentID;
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            LoadEquipmentDetails(_equipmentID);
        }

        private void LoadEquipmentDetails(int id)
        {
            try
            {
                Equipment equipment =
                    _equipmentService.getEquipmentById(id);

                if (equipment == null)
                {
                    MessageBox.Show(
                        "The equipment record could not be found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                txtEquipmentID.Text = equipment.equipmentID.ToString();
                textName.Text = equipment.eName;
                textEquipmentDescription.Text = equipment.eDesc;
                textCategory.Text = equipment.categoryID.ToString();
                textLocation.Text = equipment.locationID.ToString();
                textStatus.Text = equipment.eStatus;
                textCondition.Text = equipment.eCondition;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading equipment details: {ex.Message}",
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_equipment == null)
            {
                MessageBox.Show("Equipment details are not loaded.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var editForm = new Form
            {
                Text = "Edit Equipment",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = new System.Drawing.Size(440, 290)
            })
            {
                var nameBox = new TextBox { Text = _equipment.eName, Dock = DockStyle.Fill };
                var descriptionBox = new TextBox { Text = _equipment.eDesc, Dock = DockStyle.Fill, Multiline = true };
                var statusBox = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };
                statusBox.Items.AddRange(new object[] { "Available", "Issued", "Under Maintenance", "Retired" });
                if (!statusBox.Items.Contains(_equipment.eStatus)) statusBox.Items.Add(_equipment.eStatus);
                statusBox.SelectedItem = _equipment.eStatus;
                var conditionBox = new TextBox { Text = _equipment.eCondition, Dock = DockStyle.Fill };
                var layout = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12), ColumnCount = 2, RowCount = 5 };
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                AddEditRow(layout, 0, "Name", nameBox);
                AddEditRow(layout, 1, "Description", descriptionBox);
                AddEditRow(layout, 2, "Status", statusBox);
                AddEditRow(layout, 3, "Condition", conditionBox);
                var buttons = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft };
                var saveButton = new Button { Text = "Save", DialogResult = DialogResult.OK, AutoSize = true };
                var cancelButton = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, AutoSize = true };
                buttons.Controls.Add(cancelButton);
                buttons.Controls.Add(saveButton);
                layout.Controls.Add(buttons, 1, 4);
                editForm.Controls.Add(layout);
                editForm.AcceptButton = saveButton;
                editForm.CancelButton = cancelButton;

                if (editForm.ShowDialog(this) != DialogResult.OK) return;
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show("Equipment name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (var conn = new MySqlConnectionFactory().CreateConnection())
                    {
                        conn.Open();
                        const string query = @"UPDATE Equipments SET eName = @name, eDesc = @description,
                                               eStatus = @status, eCondition = @condition
                                               WHERE equipmentID = @id";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", nameBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", descriptionBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", statusBox.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@condition", conditionBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", _equipmentID);
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                MessageBox.Show("No equipment record was updated.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    DataChanged = true;
                    LoadEquipmentDetails(_equipmentID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to update equipment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void AddEditRow(TableLayoutPanel layout, int row, string label, Control control)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layout.Controls.Add(new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left }, 0, row);
            layout.Controls.Add(control, 1, row);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this equipment item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    _equipmentService.retireEquipment(_equipmentID);

                if (!deleted)
                {
                    MessageBox.Show(
                        "The equipment could not be deleted.",
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                DataChanged = true;

                MessageBox.Show(
                    "Equipment deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error deleting equipment: {ex.Message}",
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}