using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
            SetupUsersGrid();
        }
        private void SetupUsersGrid()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.AutoGenerateColumns = false;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "userID", DataPropertyName = "userID", HeaderText = "ID", Width = 60, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "username", DataPropertyName = "username", HeaderText = "Username", Width = 120, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "uFName", DataPropertyName = "uFName", HeaderText = "First Name", Width = 130, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "uLName", DataPropertyName = "uLName", HeaderText = "Last Name", Width = 130, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "uEmail", DataPropertyName = "uEmail", HeaderText = "Email", Width = 180, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "uContactNumber", DataPropertyName = "uContactNumber", HeaderText = "Contact", Width = 110, ReadOnly = true });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "uRole", DataPropertyName = "uRole", HeaderText = "Role", Width = 100, ReadOnly = true });
        }

        private void btnUsersDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnARefreshEquipment_Click(object sender, EventArgs e)
        {

        }
    }
}
