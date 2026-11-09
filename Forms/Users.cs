using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Services;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.DataRepo;

namespace SanaPass_EBAAMS.Forms
{
    public partial class Users : UserControl
    {
        private readonly IUserRepository _userRepository;
        private List<User> _users = new List<User>();

        public Users()
            : this(new UserRepository(new MySqlConnectionFactory()))
        {
        }

        public Users(IUserRepository userRepository)
        {
            InitializeComponent();

            _userRepository =
                userRepository
                ?? throw new ArgumentNullException(nameof(userRepository));

            SetupUsersGrid();

            btnUsersDetails.Click += btnUsersDetails_Click;
            btnAddUser.Click += btnAddUser_Click;
            btnARefreshUsers.Click += btnARefreshUsers_Click;
            txtBoxUsersSearch.TextChanged += txtBoxUsersSearch_TextChanged;
            cmbUsersFilter.SelectedIndexChanged += txtBoxUsersSearch_TextChanged;

            LoadUsers();
        }

        private void SetupUsersGrid()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.AutoGenerateColumns = false;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "userID",
                DataPropertyName = "userID",
                HeaderText = "ID",
                Width = 60,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "username",
                DataPropertyName = "username",
                HeaderText = "Username",
                Width = 120,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "uFName",
                DataPropertyName = "uFName",
                HeaderText = "First Name",
                Width = 130,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "uLName",
                DataPropertyName = "uLName",
                HeaderText = "Last Name",
                Width = 130,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "uEmail",
                DataPropertyName = "uEmail",
                HeaderText = "Email",
                Width = 180,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "uContactNumber",
                DataPropertyName = "uContactNumber",
                HeaderText = "Contact",
                Width = 110,
                ReadOnly = true
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "uRole",
                DataPropertyName = "uRole",
                HeaderText = "Role",
                Width = 100,
                ReadOnly = true
            });
        }

        private void btnUsersDetails_Click(object sender, EventArgs e)
        {
            User user = dgvUsers.CurrentRow?.DataBoundItem as User;

            if (user == null)
            {
                MessageBox.Show(
                    "Select a user first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                $"User ID: {user.userID}\nUsername: {user.username}\n" +
                $"Name: {user.uFName} {user.uLName}\n" +
                $"Email: {user.uEmail}\nContact: {user.uContactNumber}\n" +
                $"Role: {user.uRole}",
                "User Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (var registerForm = new Register(new AuthService(_userRepository)))
            {
                registerForm.StartPosition = FormStartPosition.CenterParent;

                if (registerForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void btnARefreshUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                _users = _userRepository.getAll().ToList();

                var roles = _users
                    .Select(user => user.uRole)
                    .Where(role => !string.IsNullOrWhiteSpace(role))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .OrderBy(role => role)
                    .ToList();

                string selectedRole = cmbUsersFilter.SelectedItem as string;

                cmbUsersFilter.Items.Clear();
                cmbUsersFilter.Items.Add("All Roles");
                cmbUsersFilter.Items.AddRange(roles.Cast<object>().ToArray());

                cmbUsersFilter.SelectedItem =
                    selectedRole != null && cmbUsersFilter.Items.Contains(selectedRole)
                        ? selectedRole
                        : "All Roles";

                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load users: {ex.Message}",
                    "User List Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            if (dgvUsers == null)
            {
                return;
            }

            string search = txtBoxUsersSearch.Text.Trim();

            if (search == "Enter search")
            {
                search = string.Empty;
            }

            string selectedRole = cmbUsersFilter.SelectedItem as string;

            var filtered = _users
                .Where(user =>
                    (string.IsNullOrEmpty(search) ||
                     (user.username ?? string.Empty)
                         .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     (user.uFName ?? string.Empty)
                         .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     (user.uLName ?? string.Empty)
                         .IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                     user.userID.ToString().Contains(search)) &&
                    (string.IsNullOrEmpty(selectedRole) ||
                     selectedRole == "All Roles" ||
                     user.uRole == selectedRole))
                .ToList();

            dgvUsers.DataSource = filtered;
            lblATotalUsers.Text = filtered.Count.ToString();
        }

        private void txtBoxUsersSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
