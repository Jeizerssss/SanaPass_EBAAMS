using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS.Forms
{
    public partial class PaymentHistories : UserControl
    {
        private readonly PaymentHistoryRepository _repository = new PaymentHistoryRepository(new MySqlConnectionFactory());
        private List<PaymentHistory> _payments = new List<PaymentHistory>();

        public PaymentHistories()
        {
            InitializeComponent();
            SetupPaymentHistoryGrid();
            btnARefreshPaymentHistories.Click += btnARefreshPaymentHistories_Click;
            btnPaymentDetails.Click += btnPaymentDetails_Click;
            btnPaymentHistoriesExport.Click += btnPaymentHistoriesExport_Click;
            txtBoxPaymentSearch.TextChanged += txtBoxPaymentSearch_TextChanged;
            cmbPaymentFilter.SelectedIndexChanged += txtBoxPaymentSearch_TextChanged;
            cmbPaymentFilter.Items.Add("All Histories");
            cmbPaymentFilter.SelectedIndex = 0;
            LoadPaymentHistories();
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

            dgvPaymentHistory.ReadOnly = true;
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentHistory.MultiSelect = false;
        }

        private void LoadPaymentHistories()
        {
            try
            {
                _payments = _repository.getAll().ToList();
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load payment histories: {ex.Message}", "Payment History Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            string search = txtBoxPaymentSearch.Text.Trim();
            if (search == "Enter search") search = string.Empty;
            dgvPaymentHistory.DataSource = _payments.Where(payment =>
                string.IsNullOrEmpty(search) ||
                payment.paymentHistoriesID.ToString().Contains(search) ||
                payment.userID.ToString().Contains(search) ||
                (payment.pHType ?? string.Empty).IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        private void btnARefreshPaymentHistories_Click(object sender, EventArgs e)
        {
            LoadPaymentHistories();
        }

        private void txtBoxPaymentSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnPaymentDetails_Click(object sender, EventArgs e)
        {
            PaymentHistory payment = dgvPaymentHistory.CurrentRow?.DataBoundItem as PaymentHistory;
            if (payment == null)
            {
                MessageBox.Show("Select a payment record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Payment #{payment.paymentHistoriesID}\nUser: {payment.userID}\nType: {payment.pHType}\n" +
                $"Amount received: {payment.amountReceived:C2}\nAccount balance: {payment.accountBalance:C2}\n" +
                $"Remaining balance: {payment.remainingBalance:C2}\nDate: {payment.pDate:g}",
                "Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPaymentHistoriesExport_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt",
                FileName = $"PaymentHistories_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var rows = dgvPaymentHistory.Rows.Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Select(row => string.Join(",", row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => QuoteCsv(Convert.ToString(cell.Value)))));
                    File.WriteAllLines(dialog.FileName,
                        new[] { "Payment ID,User ID,Type,Amount Received,Remaining Balance,Payment Date" }
                            .Concat(rows));
                    MessageBox.Show("Payment histories exported.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to export payment histories: {ex.Message}", "Export Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string QuoteCsv(string value)
        {
            return "\"" + (value ?? string.Empty).Replace("\"", "\"\"") + "\"";
        }
    }
}
