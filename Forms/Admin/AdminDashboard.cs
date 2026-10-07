using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanaPass_EBAAMS
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrowRequests_Click(object sender, EventArgs e)
        {
            BorrowRequests nextForm = new BorrowRequests();
            nextForm.Show();
            
        }

        private void btnTransactionLogs_Click(object sender, EventArgs e)
        {
            TransactionLogs nextForm = new TransactionLogs();
            nextForm.Show();
            
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance nextForm = new Maintenance();
            nextForm.Show();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn nextForm = new LogIn();
            nextForm.Show();
            this.Hide();
        }
    }
}
