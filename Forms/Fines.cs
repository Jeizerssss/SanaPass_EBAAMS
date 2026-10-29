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
    public partial class Fines : UserControl
    {
        public Fines()
        {
            InitializeComponent();
        }

        private void Fines_Load(object sender, EventArgs e)
        {
            SetupFinesGrid();
            // TODO: LoadFinesData(); once your database connection is active
        }

        private void SetupFinesGrid()
        {
            dgvAFines.Columns.Clear();
            dgvAFines.AutoGenerateColumns = false;

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineID", DataPropertyName = "fineID", HeaderText = "Fine ID", Width = 60, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "borrowerName", DataPropertyName = "borrowerName", HeaderText = "Borrower", Width = 150, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "eName", DataPropertyName = "eName", HeaderText = "Equipment", Width = 150, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineReason", DataPropertyName = "fineReason", HeaderText = "Reason / Violation", Width = 180, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineAmount", DataPropertyName = "fineAmount", HeaderText = "Amount", Width = 90, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "dateIssued", DataPropertyName = "dateIssued", HeaderText = "Date Issued", Width = 110, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineStatus", DataPropertyName = "fineStatus", HeaderText = "Status", Width = 100, ReadOnly = true });
        }

        private void btnSettleFine_Click(object sender, EventArgs e)
        {
            if (dgvAFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a fine record to settle.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedFineId = Convert.ToInt32(dgvAFines.SelectedRows[0].Cells["fineID"].Value);

            DialogResult result = MessageBox.Show(
                "Mark this fine as paid and record the transaction?",
                "Confirm Settlement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // TODO: Update fine status to 'Paid' and insert into payments table
                MessageBox.Show("Fine successfully settled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // LoadFinesData();
            }
        }
    }
}