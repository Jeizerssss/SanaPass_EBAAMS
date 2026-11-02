using SanaPass_EBAAMS.Interfaces;  
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Helpers;
using SanaPass_EBAAMS.Forms;
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
    public partial class BSUI : Form
    {
        private readonly User _currentUser;
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;
        private readonly IUserService _userService;
        private readonly Button[] _navigationButtons;
        private BDashboard dashboardControl = new BDashboard();
        private BrowseCatalog browseControl = new BrowseCatalog();
        private FinesAndPenalties finesControl = new FinesAndPenalties();
        private MyRequests requestControl = new MyRequests();
        

        public BSUI()
        {
            InitializeComponent();

            _navigationButtons = new[]
            {
                btnDashboard,
                btnBrowseCatalog,
                btnMyRequests,
                btnFinesAndPenalties,
                btnProfile
            };
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

            foreach (Button button in _navigationButtons)
            {
                button.BackColor = button == activeButton
                    ? highlightColor
                    : normalColor;
            }
        }
        private void SwitchUserControl(System.Windows.Forms.UserControl userControl)
        {
            if (panelContainer == null) return;

            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            NavigationButtonHelper.HighlightButton(
                        _navigationButtons,
                        btnDashboard);
            SwitchUserControl(dashboardControl);

        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBrowseCatalog);
            NavigationButtonHelper.HighlightButton(
                        _navigationButtons,
                        btnBrowseCatalog);
            SwitchUserControl(browseControl);
        }

        private void btnMyRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMyRequests);
            NavigationButtonHelper.HighlightButton(
                        _navigationButtons,
                        btnMyRequests);
            SwitchUserControl(requestControl);
        }

        private void btnFinesAndPenalties_Click(object sender, EventArgs e)
        {
            HighlightButton(btnFinesAndPenalties);
            NavigationButtonHelper.HighlightButton(
                        _navigationButtons,
                        btnFinesAndPenalties);
            SwitchUserControl(finesControl);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProfile);

            UserProfile profileControl =
                new UserProfile(
                    _currentUser,
                    _userService);

            profileControl.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
