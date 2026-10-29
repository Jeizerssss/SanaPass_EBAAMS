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
    public partial class PaymentHistories : UserControl
    {
        public PaymentHistories()
        {
            InitializeComponent();
            SetupPaymentHistoryGrid();
        }
        private void SetupPaymentHistoryGrid()
        {
            dgvPaymentHistory.Columns.Clear();
            dgvPaymentHistory.AutoGenerateColumns = false;

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "paymentID", DataPropertyName = "paymentID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "referenceNo", DataPropertyName = "referenceNo", HeaderText = "Ref No.", Width = 110, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "borrowerName", DataPropertyName = "borrowerName", HeaderText = "Borrower", Width = 160, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "paymentType", DataPropertyName = "paymentType", HeaderText = "Type", Width = 120, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "amount", DataPropertyName = "amount", HeaderText = "Amount", Width = 90, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "paymentDate", DataPropertyName = "paymentDate", HeaderText = "Date Paid", Width = 110, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "status", DataPropertyName = "status", HeaderText = "Status", Width = 100, ReadOnly = true });
        }
    }
}
