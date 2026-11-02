using System;
using System.Linq;
using System.Windows.Forms;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;

namespace SanaPass_EBAAMS
{
    public partial class Register : Form
    {
        private readonly IAuthService _authService;
        private readonly bool _dialogMode;

        // Default constructor for WinForms Designer
        public Register()
        {
            InitializeComponent();
        }

        // Dependency injection constructor
        public Register(IAuthService authService, bool dialogMode = false) : this()
        {
            _authService = authService;
            _dialogMode = dialogMode;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Gather input from controls (matching UI fields and designer names)
            string fName = txtBoxFName.Text.Trim();
            string lName = txtBoxLName.Text.Trim();
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

                if (_dialogMode)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                ShowLogin();
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
            ShowLogin();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            Form loginForm = Application.OpenForms
                .Cast<Form>()
                .FirstOrDefault(form => form is LogIn);

            if (loginForm == null)
            {
                loginForm = new LogIn();
            }

            loginForm.Show();
            loginForm.Activate();
            Close();
        }
    }
}