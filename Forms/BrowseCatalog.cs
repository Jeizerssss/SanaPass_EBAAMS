using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class BrowseCatalog : UserControl
    {
        private readonly IEquipmentService _equipmentService;
        private IRequestService _requestService;
        private User _currentUser;

        private TextBox txtSearch;
        private TextBox txtPurpose;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnRequest;
        private DataGridView dgvCatalog;
        private Label lblTitle;

        public BrowseCatalog()
        {
            InitializeInterface();
        }

        public BrowseCatalog(IEquipmentService equipmentService)
            : this()
        {
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            LoadCatalog();
        }

        public BrowseCatalog(
            IEquipmentService equipmentService,
            IRequestService requestService,
            User currentUser)
            : this(equipmentService)
        {
            _requestService = requestService
                ?? throw new ArgumentNullException(nameof(requestService));
            _currentUser = currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));
        }

        private void InitializeInterface()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            lblTitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 55,
                Text = "Browse Equipment Catalog",
                Font = new Font(
                    "Microsoft Sans Serif",
                    20F,
                    FontStyle.Bold),
                ForeColor = Color.Maroon,
                Padding = new Padding(15, 10, 0, 0)
            };

            Panel searchPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                Padding = new Padding(15, 8, 15, 8)
            };

            txtSearch = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Microsoft Sans Serif",
                    11F),
                Text = "Search equipment..."
            };

            btnRefresh = new Button
            {
                Dock = DockStyle.Right,
                Width = 90,
                Text = "Refresh",
                BackColor = Color.White
            };

            btnSearch = new Button
            {
                Dock = DockStyle.Right,
                Width = 90,
                Text = "Search",
                BackColor = Color.White
            };

            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;

            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Controls.Add(btnRefresh);

            dgvCatalog = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            ConfigureGrid();

            Panel requestPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Padding = new Padding(15, 7, 15, 7)
            };

            txtPurpose = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 10F),
                Text = "Purpose for borrowing"
            };

            btnRequest = new Button
            {
                Dock = DockStyle.Right,
                Width = 130,
                Text = "Request Selected"
            };
            btnRequest.Click += btnRequest_Click;

            requestPanel.Controls.Add(txtPurpose);
            requestPanel.Controls.Add(btnRequest);

            Controls.Add(dgvCatalog);
            Controls.Add(requestPanel);
            Controls.Add(searchPanel);
            Controls.Add(lblTitle);
        }

        private void ConfigureGrid()
        {
            dgvCatalog.Columns.Clear();

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "equipmentID",
                DataPropertyName = "equipmentID",
                HeaderText = "ID",
                Visible = false
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eName",
                DataPropertyName = "eName",
                HeaderText = "Equipment Name"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eDesc",
                DataPropertyName = "eDesc",
                HeaderText = "Description"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eStatus",
                DataPropertyName = "eStatus",
                HeaderText = "Status"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ePrice",
                DataPropertyName = "ePrice",
                HeaderText = "Price",
                DefaultCellStyle =
                {
                    Format = "C2"
                }
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eCondition",
                DataPropertyName = "eCondition",
                HeaderText = "Condition"
            });
        }

        private void LoadCatalog()
        {
            if (_equipmentService == null)
            {
                return;
            }

            try
            {
                string keyword = txtSearch.Text.Trim();
                if (keyword == "Search equipment...")
                {
                    keyword = string.Empty;
                }

                IEnumerable<Equipment> equipment =
                    _equipmentService.searchAvailableEquipment(keyword);

                dgvCatalog.DataSource = equipment
                    .Where(item =>
                        string.Equals(
                            item.eStatus,
                            "Available",
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load equipment catalog: {ex.Message}",
                    "Catalog Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            LoadCatalog();
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();
            LoadCatalog();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (_currentUser == null || _requestService == null)
            {
                MessageBox.Show(
                    "Borrowing services are unavailable.",
                    "Request Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (dgvCatalog.CurrentRow == null ||
                !(dgvCatalog.CurrentRow.DataBoundItem is Equipment equipment))
            {
                MessageBox.Show(
                    "Select an equipment item first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show(
                    "Enter the purpose for borrowing.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPurpose.Focus();
                return;
            }

            try
            {
                bool created = _requestService.createRequest(new Request
                {
                    userID = _currentUser.userID,
                    equipmentID = equipment.equipmentID,
                    rLocation = equipment.locationID.ToString(),
                    rDesc = txtPurpose.Text.Trim()
                });

                if (!created)
                {
                    MessageBox.Show(
                        "The request could not be saved.",
                        "Request Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(
                    "Borrow request submitted.",
                    "Request Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPurpose.Clear();
                LoadCatalog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to submit the request: {ex.Message}",
                    "Request Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadCatalog();
            }
        }

        private void txtBoxEquipmentSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
