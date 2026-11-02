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

namespace SanaPass_EBAAMS.Forms
{
    public partial class BSUI : Form
    {
        private readonly User _currentUser;
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;
        private readonly IUserService _userService;

        public BSUI()
        {
            InitializeComponent();
        }

        public BSUI(
            User user,
            IEquipmentService equipmentService,
            IRequestService requestService,
            IUserService userService)
            : this()
        {
            _currentUser = user
                ?? throw new ArgumentNullException(nameof(user));

            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            _requestService = requestService
                ?? throw new ArgumentNullException(nameof(requestService));

            _userService = userService
                ?? throw new ArgumentNullException(nameof(userService));
        }

        private void SwitchUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void HighlightButton(Button activeButton)
        {
            Color normalColor = Color.Transparent;
            Color highlightColor = Color.FromArgb(180, 0, 0);

            btnDashboard.BackColor = normalColor;
            btnBrowseCatalog.BackColor = normalColor;
            btnMyRequests.BackColor = normalColor;
            btnFinesAndPenalties.BackColor = normalColor;
            btnProfile.BackColor = normalColor;

            if (activeButton != null)
            {
                activeButton.BackColor = highlightColor;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            var dashboard = new BDashboard(_currentUser, _requestService);
            dashboard.BrowseCatalogRequested += btnBrowseCatalog_Click;
            dashboard.ViewAllRequestsRequested += btnMyRequests_Click;
            SwitchUserControl(dashboard);
        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBrowseCatalog);
            SwitchUserControl(new BrowseCatalog(
                _equipmentService,
                _requestService,
                _currentUser));
        }

        private void btnMyRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMyRequests);
            SwitchUserControl(new BorrowRequests(
                _requestService,
                _currentUser.userID));
        }

        private void btnFinesAndPenalties_Click(object sender, EventArgs e)
        {
            HighlightButton(btnFinesAndPenalties);
            SwitchUserControl(new Fines(0, _currentUser.userID));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProfile);
            using (UserProfile userProfile = new UserProfile(_currentUser, _userService))
            {
                userProfile.StartPosition = FormStartPosition.CenterParent;
                userProfile.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms
                .Cast<Form>()
                .FirstOrDefault(form => form is LogIn);

            if (loginForm != null)
            {
                loginForm.Show();
                loginForm.Activate();
            }

            Close();
        }
    }
}
