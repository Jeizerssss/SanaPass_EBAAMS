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
    public partial class BorrowerDashboard : Form
    {
        public BorrowerDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();

            this.Close();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            using (BorrowRequestForm borrowForm = new BorrowRequestForm())
            {
                borrowForm.ShowDialog();
            }
        }
    }
}
