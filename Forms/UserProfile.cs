using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class UserProfile : Form
    {
        private readonly User _currentUser;
        private readonly IUserService _userService;

        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(
            User currentUser,
            IUserService userService)
            : this()
        {
            _currentUser = currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));

            _userService = userService
                ?? throw new ArgumentNullException(nameof(userService));

            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            txtName.Text = string.Join(
                " ",
                _currentUser.uFName,
                _currentUser.uMName,
                _currentUser.uLName).Trim();

            txtUserID.Text = _currentUser.userID.ToString();
            txtUsername.Text = _currentUser.username;
            txtUserEmail.Text = _currentUser.uEmail;
            txtUserContactNo.Text = _currentUser.uContactNumber;
            txtUserRole.Text = _currentUser.uRole;
            txtUserStatus.Text = _currentUser.uStatus;
        }

        private void btnEditProfile_Click(
            object sender,
            EventArgs e)
        {
            if (_currentUser == null ||
                _userService == null)
            {
                MessageBox.Show(
                    "User profile services are unavailable.",
                    "Profile Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (var editForm = new EditUserProfile(
                _currentUser,
                _userService))
            {
                editForm.StartPosition =
                    FormStartPosition.CenterParent;

                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUserDetails();
                }
            }
        }

        private void btnChangePassword_Click(
            object sender,
            EventArgs e)
        {
            if (_currentUser == null ||
                _userService == null)
            {
                return;
            }

            using (var passwordForm = new ChangePassword(
                _currentUser,
                _userService))
            {
                passwordForm.StartPosition =
                    FormStartPosition.CenterParent;

                passwordForm.ShowDialog(this);
            }
        }
    }
}
