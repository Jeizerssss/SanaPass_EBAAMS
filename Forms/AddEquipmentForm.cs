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

namespace SanaPass_EBAAMS.Forms
{
    public partial class AddEquipmentForm : Form
    {
        private readonly IEquipmentService _equipmentService;

        public AddEquipmentForm()
        {
            InitializeComponent();
            LoadLookupData();
        }

        public AddEquipmentForm(IEquipmentService equipmentService)
            : this()
        {
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));
        }

        public bool DataChanged { get; set; } = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_equipmentService == null)
            {
                MessageBox.Show(
                    "The equipment service is not available.",
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show(
                    "Equipment name cannot be empty.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Equipment equipment = new Equipment
            {
                eName = textBoxName.Text.Trim(),
                eDesc = textBoxEquipmentDescription.Text.Trim(),
                categoryID = Convert.ToInt32(comboBoxCategory.SelectedValue ?? 1),
                locationID = Convert.ToInt32(comboBoxLocation.SelectedValue ?? 1),
                eStatus = comboBoxStatus.Text.Trim(),
                eCondition = "Good"
            };

            try
            {
                bool added = _equipmentService.registerEquipment(equipment);

                if (!added)
                {
                    MessageBox.Show(
                        "The equipment could not be added.",
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                DataChanged = true;
                DialogResult = DialogResult.OK;

                MessageBox.Show(
                    "Equipment added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error saving equipment: {ex.Message}",
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
