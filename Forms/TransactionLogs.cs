using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class TransactionLogs : UserControl
    {
        private readonly TransactionLogRepository _repository =
            new TransactionLogRepository(
                new MySqlConnectionFactory());

        private List<TransactionLog> _logs =
            new List<TransactionLog>();

        public TransactionLogs()
        {
            InitializeComponent();
            SetupGrid();

            btnARefreshTransactionLogs.Click +=
                btnARefreshTransactionLogs_Click;

            btnPaymentDetails.Click +=
                btnPaymentDetails_Click;

            btnPaymentHistoriesExport.Click +=
                btnPaymentHistoriesExport_Click;

            txtBoxLogSearch.TextChanged +=
                txtBoxLogSearch_TextChanged;

            cmbLogsFilter.SelectedIndexChanged +=
                txtBoxLogSearch_TextChanged;

            cmbLogsFilter.Items.Add("All Histories");
            cmbLogsFilter.SelectedIndex = 0;

            LoadLogs();
        }

        private void SetupGrid()
        {
            dgvTransactionLogs.AutoGenerateColumns = false;
            dgvTransactionLogs.Columns.Clear();
            dgvTransactionLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "transactionLogID", DataPropertyName = "transactionLogID",
                HeaderText = "Log ID", Width = 90, ReadOnly = true
            });
            dgvTransactionLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tlDate", DataPropertyName = "tlDate",
                HeaderText = "Date", Width = 160, ReadOnly = true,
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm" }
            });
            dgvTransactionLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "requestID", DataPropertyName = "requestID",
                HeaderText = "Request ID", Width = 110, ReadOnly = true
            });
            dgvTransactionLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "handledBy", DataPropertyName = "handledBy",
                HeaderText = "Handled By", Width = 110, ReadOnly = true
            });
            dgvTransactionLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tlType", DataPropertyName = "tlType",
                HeaderText = "Transaction", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });
            dgvTransactionLogs.ReadOnly = true;
            dgvTransactionLogs.AllowUserToAddRows = false;
            dgvTransactionLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionLogs.MultiSelect = false;
        }

        private void LoadLogs()
        {
            try
            {
                _logs = _repository.getAll().ToList();
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load transaction logs: {ex.Message}", "Transaction Log Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            string search = txtBoxLogSearch.Text.Trim();
            if (search == "Enter search") search = string.Empty;
            dgvTransactionLogs.DataSource = _logs.Where(log =>
                string.IsNullOrEmpty(search) ||
                log.transactionLogID.ToString().Contains(search) ||
                log.requestID.ToString().Contains(search) ||
                log.handledBy.ToString().Contains(search) ||
                (log.tlType ?? string.Empty).IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        private void btnARefreshTransactionLogs_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void txtBoxLogSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnPaymentDetails_Click(object sender, EventArgs e)
        {
            TransactionLog log = dgvTransactionLogs.CurrentRow?.DataBoundItem as TransactionLog;
            if (log == null)
            {
                MessageBox.Show("Select a transaction log first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Log #{log.transactionLogID}\nTransaction: {log.tlType}\nRequest: {log.requestID}\n" +
                $"Handled by: {log.handledBy}\nDate: {log.tlDate:g}",
                "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPaymentHistoriesExport_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt",
                FileName = $"TransactionLogs_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var lines = dgvTransactionLogs.Rows.Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow)
                        .Select(row => string.Join(",", row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => "\"" + (Convert.ToString(cell.Value) ?? string.Empty).Replace("\"", "\"\"") + "\"")));
                    File.WriteAllLines(dialog.FileName,
                        new[] { "Log ID,Date,Request ID,Handled By,Transaction" }.Concat(lines));
                    MessageBox.Show("Transaction logs exported.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to export transaction logs: {ex.Message}", "Export Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
