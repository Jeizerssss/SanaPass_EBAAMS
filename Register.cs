using System;
using System.Windows.Forms;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS
{
    public partial class Register : Form
    {
        private readonly IAuthService _authService;

        // Default constructor for WinForms Designer
        public Register()
        {
            InitializeComponent();
        }

        // Dependency injection constructor
        public Register(IAuthService authService) : this()
        {
            _authService = authService;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Gather input from controls
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string fName = txtFName.Text.Trim();
            string lName = txtLName.Text.Trim();
            string mName = txtMName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string role = cboRole?.SelectedItem?.ToString() ?? "Borrower";

            // 2. Validate required fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 3. Instantiate model with property names matching User.cs
            User newUser = new User
            {
                username = username,
                password = password,
                uFName = fName,
                uLName = lName,
                uMName = mName,
                uEmail = email,
                uContactNumber = contact,
                uRole = role
            };

            // 4. Save through AuthService
            bool isSuccess = _authService != null && _authService.register(newUser);

            if (isSuccess)
            {
                MessageBox.Show(
                    "Success! Please go to the PPMGS office for verification.",
                    "Registration Successful.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Return to LogIn Form
                this.Hide();
                LogIn loginForm = new LogIn();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Registration failed. The username may already exist or system services are unavailable.",
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }
    }
}