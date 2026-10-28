using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using SanaPass_EBAAMS.Forms;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    public partial class ASUI : Form
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;
        private readonly User _currentUser;

        // 1. Safe default constructor (prevents crashes if called without parameters)
        public ASUI()
        {
            InitializeComponent();
        }

        // 2. Primary Dependency Injection constructor
        public ASUI(IEquipmentService equipmentService, IRequestService requestService, User currentUser) : this()
        {
            _equipmentService = equipmentService;
            _requestService = requestService;
            _currentUser = currentUser ?? new User { uRole = "admin" }; // Fallback user if null

            ApplyRoleBasedAccessControl();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Safely load default view on startup (e.g., loading the Dashboard first)
            if (pnlSideBar != null)
            {
                try
                {
                    ADashboard dashboardControl = new ADashboard();
                    SwitchUserControl(dashboardControl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading initial view: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ApplyRoleBasedAccessControl()
        {
            if (_currentUser != null && !string.IsNullOrEmpty(_currentUser.uRole))
            {
                string role = _currentUser.uRole.Trim().ToLower();
                if (role == "staff")
                {
                    // Staff-specific UI adjustments here
                }
            }
        }

        private void SwitchUserControl(System.Windows.Forms.UserControl userControl)
        {
            if (pnlSideBar == null) return; // Silent fail guard to prevent hard crashes

            pnlSideBar.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlSideBar.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ADashboard dashboardControl = new ADashboard();
            SwitchUserControl(dashboardControl);
        }

        private void btnBorrowRequests_Click(object sender, EventArgs e)
        {
            if (_requestService != null)
            {
                BorrowRequests borrowRequestsControl = new BorrowRequests(_requestService);
                SwitchUserControl(borrowRequestsControl);
            }
            else
            {
                MessageBox.Show("Request service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransactionLogs_Click(object sender, EventArgs e)
        {
            // Transaction logs handler
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            // Maintenance handler
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Close();
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {
            // Paint event handler
        }
    }
}
