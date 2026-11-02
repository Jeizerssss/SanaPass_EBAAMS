using SanaPass_EBAAMS.Interfaces;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class ADashboard : UserControl
    {
        private readonly IReportService _reportService;

        public ADashboard()
        {
            InitializeComponent();
            btnARefreshRequest.Click += btnARefreshRequest_Click;
        }

        public ADashboard(IReportService reportService)
            : this()
        {
            _reportService = reportService
                ?? throw new ArgumentNullException(nameof(reportService));
        }

        private void ADashboard_Load(
            object sender,
            EventArgs e)
        {
            RefreshDashboard();
        }

        private void btnARefreshRequest_Click(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            if (_reportService == null)
            {
                return;
            }

            try
            {
                lblEquipmentCard.Text = "AVAILABLE EQUIPMENT (" + _reportService.getAvailableEquipmentCount() + ")";
                lblRequestsCard.Text = "PENDING REQUESTS (" + _reportService.getPendingRequestsCount() + ")";
                lblBorrowsCard.Text = "ACTIVE BORROWS (" + _reportService.getBorrowedItemsCount() + ")";
                lblReturnCard.Text = "OVERDUE RETURN (" + _reportService.getOverdueReturnCount() + ")";
                lblALastChecked.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to refresh dashboard data: {ex.Message}", "Dashboard Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(
            object sender,
            EventArgs e)
        {
            if (_reportService == null)
            {
                MessageBox.Show(
                    "The report service is not available.",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                string report = _reportService.buildBusinessSummary();

                using (var dialog = new SaveFileDialog())
                {
                    dialog.Title = "Export Business Summary";
                    dialog.Filter =
                        "Text files (*.txt)|*.txt|" +
                        "CSV files (*.csv)|*.csv";
                    dialog.FileName =
                        $"BusinessSummary_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                    if (dialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    File.WriteAllText(
                        dialog.FileName,
                        report,
                        Encoding.UTF8);

                    MessageBox.Show(
                        "The business summary was exported successfully.",
                        "Report Exported",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to export the report: {ex.Message}",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
