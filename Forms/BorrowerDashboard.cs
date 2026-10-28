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
using SanaPass_EBAAMS.Interfaces;  

namespace SanaPass_EBAAMS
{
    public partial class BorrowerDashboard : Form
    {
        // Add private fields for the parameters if needed
        // private User _user;
        // private IEquipmentService _equipmentService;
        // private IRequestService _requestService;

        public BorrowerDashboard()
        {
            InitializeComponent();
        }

        // Add this constructor to BorrowerDashboard to match the usage in LogIn.cs
        public BorrowerDashboard(User user, IEquipmentService equipmentService, IRequestService requestService)
            : this()
        {
            // Assign parameters to fields or use as needed
            // Example:
            // _user = user;
            // _equipmentService = equipmentService;
            // _requestService = requestService;
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
