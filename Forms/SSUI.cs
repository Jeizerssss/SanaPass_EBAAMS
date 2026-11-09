using SanaPass_EBAAMS.Helpers;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
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
    public partial class SSUI : Form
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;
        private readonly IUserService _userService;
        private readonly User _currentUser;
        private readonly Button[] _navigationButtons;
        private SDashboard dashboardControl;
        private BorrowRequests requestControl = new BorrowRequests();
        private Equipments equipmentsControl;
        private Fines finesControl;
        private PaymentHistories paymentHistoriesControl;
        private Maintenance maintenanceControl = new Maintenance();

        public SSUI()
        {
            InitializeComponent();

            _navigationButtons = new[]
            {
                btnDashboard,
                btnRequests,
                btnEquipment,
                btnPaymentHistories,
                btnFines,
                btnMaintenance,
                btnProfile
            };
        }
        public SSUI(
            IEquipmentService equipmentService,
            IRequestService requestService,
            IUserService userService,
            User currentUser) : this()
        {
            _equipmentService =
                equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            _requestService =
                requestService
                ?? throw new ArgumentNullException(nameof(requestService));

            _userService =
                userService
                ?? throw new ArgumentNullException(nameof(userService));

            _currentUser =
                currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));

            dashboardControl = new SDashboard();
            equipmentsControl = new Equipments(_equipmentService);
            finesControl = new Fines();
            paymentHistoriesControl = new PaymentHistories();
        }
        private void SSUI_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
            {
                string displayName = !string.IsNullOrEmpty(_currentUser.username) ? _currentUser.username : "Admin";
                btnProfile.Text = $"Profile ({displayName})";
            }
            else
            {
                btnProfile.Text = "Profile (Admin)";
            }

            
            if (panelContainer != null)
            {
                try
                {
                    NavigationButtonHelper.HighlightButton(
                        _navigationButtons,
                        btnDashboard);
                    SwitchUserControl(dashboardControl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading initial view: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SwitchUserControl(UserControl userControl)
        {
            if (panelContainer == null || userControl == null)
            {
                return;
            }

            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnEquipment);

            SwitchUserControl(equipmentsControl);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnRequests);

            SwitchUserControl(requestControl);
        }

        private void btnPaymentHistories_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnPaymentHistories);

            SwitchUserControl(paymentHistoriesControl);
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnFines);

            SwitchUserControl(finesControl);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnMaintenance);

            SwitchUserControl(maintenanceControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigationButtonHelper.HighlightButton(
                _navigationButtons,
                btnDashboard);

            SwitchUserControl(dashboardControl);
        }
    }
}
