using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class ChangePassword : Form
    {
        private readonly User _currentUser;
        private readonly IUserService _userService;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(
            User currentUser,
            IUserService userService)
            : this()
        {
            _currentUser = currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));

            _userService = userService
                ?? throw new ArgumentNullException(nameof(userService));

            ConfigurePasswordFields();
        }

        private void ConfigurePasswordFields()
        {
            textBoxCurrentPassword.UseSystemPasswordChar = true;
            textBoxNewPassword1.UseSystemPasswordChar = true;
            textBoxNewPassword2.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            string currentPassword =
                textBoxCurrentPassword.Text;

            string newPassword =
                textBoxNewPassword1.Text;

            string confirmation =
                textBoxNewPassword2.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmation))
            {
                MessageBox.Show(
                    "All password fields are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show(
                    "The new password must contain at least 8 characters.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (newPassword != confirmation)
            {
                MessageBox.Show(
                    "The new passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (newPassword == currentPassword)
            {
                MessageBox.Show(
                    "The new password must be different from the current password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool changed = _userService.changePassword(
                _currentUser.userID,
                currentPassword,
                newPassword);

            if (!changed)
            {
                MessageBox.Show(
                    "The current password is incorrect or the password could not be changed.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "Password changed successfully.",
                "Password Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
