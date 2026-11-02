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
            { Name = "paymentHistoriesID", DataPropertyName = "paymentHistoriesID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "userID", DataPropertyName = "userID", HeaderText = "User ID", Width = 80, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "pHType", DataPropertyName = "pHType", HeaderText = "Type", Width = 120, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "amountReceived", DataPropertyName = "amountReceived", HeaderText = "Amount Received", Width = 110, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "remainingBalance", DataPropertyName = "remainingBalance", HeaderText = "Remaining Balance", Width = 130, ReadOnly = true });

            dgvPaymentHistory.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "pDate", DataPropertyName = "pDate", HeaderText = "Payment Date", Width = 110, ReadOnly = true });
        }
    }
}
