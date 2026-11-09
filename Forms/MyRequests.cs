using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class MyRequests : UserControl
    {
        private readonly IRequestService _requestService;
        private readonly int _userID;
        private List<Request> _requests =
            new List<Request>();

        public MyRequests()
        {
            InitializeComponent();

            ConfigureGrid();

            btnRefresh.Click += btnRefresh_Click;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            btnCancel.Click += btnCancel_Click;

            btnCancel.Enabled = false;
        }

        public MyRequests(
            IRequestService requestService,
            int userID)
            : this()
        {
            _requestService =
                requestService
                ?? throw new ArgumentNullException(nameof(requestService));

            _userID = userID;

            LoadRequests();
        }

        private void ConfigureGrid()
        {
            dgvMyRequests.Columns.Clear();
            dgvMyRequests.AutoGenerateColumns = false;
            dgvMyRequests.ReadOnly = true;
            dgvMyRequests.AllowUserToAddRows = false;
            dgvMyRequests.AllowUserToDeleteRows = false;
            dgvMyRequests.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMyRequests.MultiSelect = false;

            dgvMyRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "requestID",
                DataPropertyName = "requestID",
                HeaderText = "Request ID",
                Width = 90
            });

            dgvMyRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "equipmentID",
                DataPropertyName = "equipmentID",
                HeaderText = "Equipment ID",
                Width = 100
            });

            dgvMyRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "rDate",
                DataPropertyName = "rDate",
                HeaderText = "Date",
                Width = 130
            });

            dgvMyRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "rStatus",
                DataPropertyName = "rStatus",
                HeaderText = "Status",
                Width = 130
            });

            dgvMyRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "rDesc",
                DataPropertyName = "rDesc",
                HeaderText = "Purpose",
                AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill
            });

            dgvMyRequests.SelectionChanged +=
                dgvMyRequests_SelectionChanged;
        }

        private void LoadRequests()
        {
            if (_requestService == null)
            {
                return;
            }

            try
            {
                _requests =
                    _requestService
                        .getRequestsByUserId(_userID)
                        .ToList();

                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load your requests: {ex.Message}",
                    "Request Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            string selectedStatus =
                comboBox1.SelectedItem == null
                    ? "All"
                    : comboBox1.SelectedItem.ToString();

            List<Request> filteredRequests =
                _requests
                    .Where(request =>
                        selectedStatus == "All" ||
                        string.Equals(
                            request.rStatus,
                            selectedStatus,
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();

            dgvMyRequests.DataSource = filteredRequests;
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            LoadRequests();
        }

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilters();
        }

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            Request request =
                dgvMyRequests.CurrentRow?.DataBoundItem as Request;

            if (request == null)
            {
                MessageBox.Show(
                    "Select a request first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult confirmation =
                MessageBox.Show(
                    "Cancel the selected borrow request?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool cancelled =
                    _requestService.cancelRequest(
                        request.requestID,
                        _userID);

                if (!cancelled)
                {
                    MessageBox.Show(
                        "Only pending requests can be cancelled.",
                        "Cancellation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "The request was cancelled.",
                    "Request Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to cancel the request: {ex.Message}",
                    "Cancellation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvMyRequests_SelectionChanged(
            object sender,
            EventArgs e)
        {
            Request request =
                dgvMyRequests.CurrentRow?.DataBoundItem as Request;

            btnCancel.Enabled =
                request != null &&
                (string.Equals(
                    request.rStatus,
                    "Pending",
                    StringComparison.OrdinalIgnoreCase) ||
                 string.Equals(
                    request.rStatus,
                    "Pending Approval",
                    StringComparison.OrdinalIgnoreCase) ||
                 string.Equals(
                    request.rStatus,
                    "Pending Release",
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}
