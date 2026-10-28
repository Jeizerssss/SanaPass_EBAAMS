using System;
using System.Windows.Forms;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS
{
    public partial class LogIn : Form
    {
        private readonly IAuthService _authService;
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;

        // Default constructor for WinForms designer support
        public LogIn()
        {
            InitializeComponent();
        }

        // Dependency injection constructor
        public LogIn(IAuthService authService, IEquipmentService equipmentService, IRequestService requestService)
            : this()
        {
            _authService = authService;
            _equipmentService = equipmentService;
            _requestService = requestService;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Authenticate against database via AuthService
            User loggedInUser = _authService != null ? _authService.login(username, password) : null;

            if (loggedInUser != null)
            {
                MessageBox.Show(
                    $"Login successful! Welcome, {loggedInUser.uFName}.",
                    "Welcome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Hide();

                // Direct user based on database role
                if (loggedInUser.uRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                    loggedInUser.uRole.Equals("Staff", StringComparison.OrdinalIgnoreCase))
                {
                    ASUI dashboard = new ASUI(_equipmentService, _requestService, loggedInUser);
                    dashboard.Show();
                }
                else
                {
                    BorrowerDashboard dashboard = new BorrowerDashboard(loggedInUser, _equipmentService, _requestService);
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register registerForm = new Register(_authService);
            registerForm.Show();
        }
    }
}