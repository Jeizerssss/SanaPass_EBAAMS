using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    public partial class Register : Form
    {
        private readonly IAuthService _authService;

        public Register()
        {
            InitializeComponent();
        }

        public Register(IAuthService authService)
            : this()
        {
            _authService = authService
                ?? throw new ArgumentNullException(nameof(authService));
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtBoxFName.Text.Trim();
            string lastName = txtBoxLName.Text.Trim();
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show(
                    "The password must contain at least 8 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            User newUser = new User
            {
                username = username,
                password = password,
                uFName = firstName,
                uLName = lastName,
                uMName = string.Empty,
                uEmail = string.Empty,
                uContactNumber = string.Empty,
                uRole = "Borrower"
            };

            bool registered = _authService.register(newUser);

            if (!registered)
            {
                MessageBox.Show(
                    "Registration failed. The username may already exist.",
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "Registration successful. Wait for the administrator to approve your account.",
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblLogin_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
        }

        
    }
}