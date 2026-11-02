using SanaPass_EBAAMS.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS.Forms
{
    public partial class BorrowRequests : UserControl
    {
        private readonly IRequestService _requestService;
        private readonly int? _userID;
        private List<SanaPass_EBAAMS.Models.Request> _requests =
            new List<SanaPass_EBAAMS.Models.Request>();

        // 1. Default parameterless constructor required by the Visual Studio Designer
        public BorrowRequests()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            btnARefreshRequest.Click += btnARefreshRequest_Click;
            btnARequestDetails.Click += btnARequestDetails_Click;
            btnAApproveAll.Click += btnAApproveAll_Click;
            btnAReturnAll.Click += btnAReturnAll_Click;
            cmbAFilterStatus.SelectedIndexChanged += textBox1_TextChanged;
            btnAApproveAll.Text = "Approve & Issue";
            cmbAFilterStatus.Items.AddRange(new object[]
            {
                "All", "Pending", "Pending Approval", "Pending Release",
                "Pending Return", "Approved", "Returned", "Rejected"
            });
            cmbAFilterStatus.SelectedIndex = 0;
        }

        // 2. Dependency Injection constructor used by ASUI to pass the service
        public BorrowRequests(IRequestService requestService, int? userID = null) : this()
        {
            _requestService = requestService
                ?? throw new ArgumentNullException(nameof(requestService));
            _userID = userID;
            btnAApproveAll.Visible = !_userID.HasValue;
            btnAReturnAll.Visible = !_userID.HasValue;
            LoadBorrowRequests();
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            if (_requestService != null)
            {
                LoadBorrowRequests();
            }
        }

        private void LoadBorrowRequests()
        {
            try
            {
                // TODO: Fetch your request data and bind it to your DataGridView (e.g., dgvRequests)
                _requests = (_userID.HasValue
                    ? _requestService.getRequestsByUserId(_userID.Value)
                    : _requestService.getAllRequests()).ToList();
                ApplyRequestFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading requests: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrowRequests_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyRequestFilters();
        }

        private void dgvARequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SetupDataGridViewColumns()
        {
            dgvARequests.Columns.Clear();
            dgvARequests.AutoGenerateColumns = false;

            // Define columns manually for precise control
            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "requestID",
                DataPropertyName = "requestID",
                HeaderText = "ID",
                Width = 60,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "userID",
                DataPropertyName = "userID",
                HeaderText = "Borrower ID",
                Width = 150,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "equipmentID",
                DataPropertyName = "equipmentID",
                HeaderText = "Equipment ID",
                Width = 180,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "rLocation",
                DataPropertyName = "rLocation",
                HeaderText = "Location",
                Width = 60,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "rDate",
                DataPropertyName = "rDate",
                HeaderText = "Date Requested",
                Width = 120,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "rStatus",
                DataPropertyName = "rStatus",
                HeaderText = "Status",
                Width = 100,
                ReadOnly = true
            });
        }

        private void ApplyRequestFilters()
        {
            if (dgvARequests == null)
            {
                return;
            }

            string search = txtBoxARequestSearch.Text.Trim();
            if (search == "Enter search")
            {
                search = string.Empty;
            }

            string status = cmbAFilterStatus.SelectedItem == null
                ? string.Empty
                : cmbAFilterStatus.SelectedItem.ToString();

            var filtered = _requests.Where(request =>
                (string.IsNullOrEmpty(search) ||
                 request.requestID.ToString().Contains(search) ||
                 request.userID.ToString().Contains(search) ||
                 request.equipmentID.ToString().Contains(search) ||
                 (request.rDesc ?? string.Empty).IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(status) || status == "All" || request.rStatus == status))
                .ToList();

            dgvARequests.DataSource = filtered;
            lblATotalRequest.Text = filtered.Count.ToString();
        }

        private void btnARefreshRequest_Click(object sender, EventArgs e)
        {
            LoadBorrowRequests();
        }

        private void btnARequestDetails_Click(object sender, EventArgs e)
        {
            if (dgvARequests.CurrentRow == null ||
                !(dgvARequests.CurrentRow.DataBoundItem is SanaPass_EBAAMS.Models.Request request))
            {
                MessageBox.Show("Select a request to view its details.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Request: #{request.requestID}\nBorrower: {request.userID}\nEquipment: {request.equipmentID}\n" +
                $"Date: {request.rDate:g}\nLocation: {request.rLocation}\nStatus: {request.rStatus}\nPurpose: {request.rDesc}",
                "Request Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAApproveAll_Click(object sender, EventArgs e)
        {
            var pendingRequests = _requests.Where(request =>
                request.rStatus == "Pending" || request.rStatus == "Pending Approval").ToList();

            if (pendingRequests.Count == 0)
            {
                MessageBox.Show("There are no pending requests to approve.", "No Pending Requests",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Approve and issue equipment for all {pendingRequests.Count} pending requests?", "Confirm Approval",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int updated = pendingRequests.Count(request => _requestService.approveRequest(request.requestID));
            LoadBorrowRequests();
            MessageBox.Show($"Approved {updated} of {pendingRequests.Count} requests.", "Approval Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAReturnAll_Click(object sender, EventArgs e)
        {
            var returnRequests = _requests.Where(request =>
                request.rStatus == "Pending Return" || request.rStatus == "Issued").ToList();

            if (returnRequests.Count == 0)
            {
                MessageBox.Show("There are no active borrows to return.", "No Active Borrows",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Mark all {returnRequests.Count} active borrows as returned?", "Confirm Return",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int updated = returnRequests.Count(request => _requestService.returnEquipment(request.requestID));
            LoadBorrowRequests();
            MessageBox.Show($"Marked {updated} of {returnRequests.Count} requests as returned.", "Return Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblARequest_Click(object sender, EventArgs e)
        {

        }

        private void lblATotalRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
