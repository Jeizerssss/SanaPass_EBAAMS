using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    public partial class BorrowRequestForm : Form
    {
        public BorrowRequestForm()
        {
            InitializeComponent();
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
