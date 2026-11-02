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
    public partial class BorrowRequestForm : Form
    {
        private User _currentUser;
        private IEquipmentService _equipmentService;
        private IRequestService _requestService;

        public BorrowRequestForm()
        {
            InitializeComponent();
        }

        public BorrowRequestForm(
            User currentUser,
            IEquipmentService equipmentService,
            IRequestService requestService) : this()
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _equipmentService = equipmentService ?? throw new ArgumentNullException(nameof(equipmentService));
            _requestService = requestService ?? throw new ArgumentNullException(nameof(requestService));
            txtBorrowerName.Text = string.Join(" ", currentUser.uFName, currentUser.uLName).Trim();
            txtBorrowerName.ReadOnly = true;
            LoadAvailableEquipment();
        }

        private void LoadAvailableEquipment()
        {
            try
            {
                cmbEquipment.DataSource = _equipmentService.getAllEquipment()
                    .Where(item => string.Equals(item.eStatus, "Available", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                cmbEquipment.DisplayMember = "eName";
                cmbEquipment.ValueMember = "equipmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load equipment: {ex.Message}", "Borrow Request Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBorrowerName.Text))
            {
                MessageBox.Show("Please enter the borrower name.");
                txtBorrowerName.Focus();
                return;
            }

            if (cmbEquipment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an equipment.");
                return;
            }

            if (dtpReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                MessageBox.Show(
                    "Return date cannot be earlier than borrow date.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show("Please enter the purpose of borrowing.");
                txtPurpose.Focus();
                return;
            }

            if (_currentUser == null || _equipmentService == null || _requestService == null)
            {
                MessageBox.Show(
                    "Borrow request services are unavailable.",
                    "Request Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Equipment equipment = cmbEquipment.SelectedItem as Equipment;
            if (equipment == null)
            {
                MessageBox.Show("Select an available equipment item.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool submitted = _requestService.createRequest(new Request
                {
                    userID = _currentUser.userID,
                    equipmentID = equipment.equipmentID,
                    rLocation = equipment.locationID.ToString(),
                    rDesc = txtPurpose.Text.Trim()
                });

                if (!submitted)
                {
                    MessageBox.Show("The request could not be saved.", "Request Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to submit the request: {ex.Message}", "Request Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                "Borrow request submitted successfully!",
                "Request Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
