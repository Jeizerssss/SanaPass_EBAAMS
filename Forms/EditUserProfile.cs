using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class EditUserProfile : Form
    {
        private readonly User _currentUser;
        private readonly IUserService _userService;

        public EditUserProfile()
        {
            InitializeComponent();
        }

        public EditUserProfile(
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

        private void EditUserProfile_Load(
            object sender,
            EventArgs e)
        {
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            if (_currentUser == null)
            {
                return;
            }

            textBoxUserFName.Text = _currentUser.uFName;
            textBoxUserLName.Text = _currentUser.uLName;
            textBoxUserMiddleName.Text = _currentUser.uMName;
            textBoxUserID.Text = _currentUser.userID.ToString();
            textBox1.Text = _currentUser.username;
            textBoxUserEmail.Text = _currentUser.uEmail;
            textBoxContactNo.Text = _currentUser.uContactNumber;
            textBoxUserStatus.Text = "Active";
            textBoxUserRole.Text = _currentUser.uRole;

            textBoxUserID.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBoxUserStatus.ReadOnly = true;
            textBoxUserRole.ReadOnly = true;
        }

        private void btnSave_Click(
            object sender,
            EventArgs e)
        {
            if (_currentUser == null ||
                _userService == null)
            {
                return;
            }

            string firstName = textBoxUserFName.Text.Trim();
            string lastName = textBoxUserLName.Text.Trim();
            string email = textBoxUserEmail.Text.Trim();
            string contactNumber = textBoxContactNo.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show(
                    "First name, last name, email, and contact number are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool updated = _userService.updateProfile(
                _currentUser.userID,
                firstName,
                lastName,
                email,
                contactNumber);

            if (!updated)
            {
                MessageBox.Show(
                    "Unable to update the profile.",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            _currentUser.uFName = firstName;
            _currentUser.uLName = lastName;
            _currentUser.uMName =
                textBoxUserMiddleName.Text.Trim();
            _currentUser.uEmail = email;
            _currentUser.uContactNumber = contactNumber;

            MessageBox.Show(
                "Profile updated successfully.",
                "Profile Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
