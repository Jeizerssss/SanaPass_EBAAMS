using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class BDashboard : UserControl
    {
        private readonly User _currentUser;
        private readonly IRequestService _requestService;

        public BDashboard()
        {
            InitializeComponent();
            ConfigureRecentRequestsGrid();
        }

        public BDashboard(
            User currentUser,
            IRequestService requestService) : this()
        {
            _currentUser = currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));

            _requestService = requestService
                ?? throw new ArgumentNullException(nameof(requestService));

            lblWelcome.Text = $"Hello, {_currentUser.username}";
            lblBorrowerAccount.Text =
                $"Borrower ID: {_currentUser.userID}";

            LoadRecentRequests();
        }

        private void ConfigureRecentRequestsGrid()
        {
            dgvMyRecentRequests.Columns.Clear();
            dgvMyRecentRequests.AutoGenerateColumns = false;
            dgvMyRecentRequests.AllowUserToAddRows = false;
            dgvMyRecentRequests.AllowUserToDeleteRows = false;
            dgvMyRecentRequests.ReadOnly = true;
            dgvMyRecentRequests.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMyRecentRequests.MultiSelect = false;
            dgvMyRecentRequests.Dock = DockStyle.Fill;
            dgvMyRecentRequests.BackgroundColor = Color.White;
            dgvMyRecentRequests.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMyRecentRequests.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "eName",
                    DataPropertyName = "eName",
                    HeaderText = "Equipment Name"
                });

            dgvMyRecentRequests.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "rDate",
                    DataPropertyName = "rDate",
                    HeaderText = "Date Requested",
                    DefaultCellStyle =
                    {
                        Format = "yyyy-MM-dd"
                    }
                });

            dgvMyRecentRequests.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "rStatus",
                    DataPropertyName = "rStatus",
                    HeaderText = "Status"
                });

            dgvMyRecentRequests.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "rDesc",
                    DataPropertyName = "rDesc",
                    HeaderText = "Purpose / Notes"
                });
        }

        private void LoadRecentRequests()
        {
            if (_currentUser == null || _requestService == null)
            {
                return;
            }

            try
            {
                var recentRequests = _requestService
                    .getRequestsByUserId(_currentUser.userID)
                    .OrderByDescending(request => request.rDate)
                    .Take(10)
                    .ToList();

                dgvMyRecentRequests.DataSource = recentRequests;

                int pendingCount = recentRequests.Count(request =>
                    request.rStatus == "Pending Approval" ||
                    request.rStatus == "Pending Release");

                int activeBorrowCount = recentRequests.Count(request =>
                    request.rStatus == "Pending Return");

                lblPendingRequestsCount.Text =
                    pendingCount.ToString();

                lblActiveBorrowsCount.Text =
                    activeBorrowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load recent requests: {ex.Message}",
                    "Request Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBorrowNewItem_Click(
            object sender,
            EventArgs e)
        {
            using (BorrowRequestForm form =
                new BorrowRequestForm())
            {
                form.StartPosition =
                    FormStartPosition.CenterParent;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadRecentRequests();
                }
            }
        }

        private void btnViewAllRequests_Click(
            object sender,
            EventArgs e)
        {
            LoadRecentRequests();
        }
    }
}
