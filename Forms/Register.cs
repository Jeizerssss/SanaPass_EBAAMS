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
            // 1. Gather input from controls (matching UI fields and designer names)
            string fName = txtBoxFName.Text.Trim();
            string lName = txtBoxPassword.Text.Trim(); // Matched to txtBoxLName from outline
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text;

            // 2. Validation
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 3. Instantiate model with default values for fields not shown in this UI version
            User newUser = new User
            {
                username = username,
                password = password,
                uFName = fName,
                uLName = lName,
                uMName = string.Empty,
                uEmail = string.Empty,
                uContactNumber = string.Empty,
                uRole = "Borrower" // Default role for self-registration
            };

            // 4. Save through AuthService
            bool isSuccess = _authService != null && _authService.register(newUser);

            if (isSuccess)
            {
                MessageBox.Show(
                    "Success! Please go to the PPMGS office for verification.",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Matched to lblLogin control name from the designer outline
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }
    }
}