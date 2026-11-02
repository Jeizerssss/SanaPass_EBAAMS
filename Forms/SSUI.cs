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
        private readonly User _currentUser;
        private BorrowRequests requestControl = new BorrowRequests();
        private Equipments equipmentsControl = new Equipments();
        private Fines finesControl = new Fines();
        private PaymentHistories paymentHistoriesControl = new PaymentHistories();
        private Maintenance maintenanceControl = new Maintenance();

        public SSUI()
        {
            InitializeComponent();
        }
        public SSUI(IEquipmentService equipmentService, IRequestService requestService, User currentUser) : this()
        {
            _equipmentService = equipmentService;
            _requestService = requestService;
            _currentUser = currentUser ?? new User { uRole = "admin" };
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

            // Safely load default view on startup (e.g., loading the Dashboard first)
            if (panelContainer != null)
            {
                try
                {
                    BorrowRequests requestsControl = new BorrowRequests();
                    SwitchUserControl(requestsControl);
                    HighlightButton(btnRequests);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading initial view: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SwitchUserControl(System.Windows.Forms.UserControl userControl)
        {
            // IMPORTANT: Changed from pnlSideBar to panelContainer so it swaps content, not your sidebar!
            if (panelContainer == null) return;

            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            HighlightButton(btnEquipment);
            SwitchUserControl(equipmentsControl);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRequests);
            SwitchUserControl(requestControl);
        }

        private void HighlightButton(Button activeButton)
        {
            Color normalColor = Color.Transparent;
            Font normalFont = new Font(btnRequests.Font, FontStyle.Regular);
            Color highlightColor = Color.FromArgb(180, 0, 0);
            Font highlightFont = new Font(btnRequests.Font, FontStyle.Bold);

            btnRequests.BackColor = normalColor;
            btnRequests.Font = normalFont;
            btnEquipment.BackColor = normalColor;
            btnEquipment.Font = normalFont;
            btnPaymentHistories.BackColor = normalColor;
            btnPaymentHistories.Font = normalFont;
            btnFines.BackColor = normalColor;
            btnFines.Font = normalFont;
            btnMaintenance.BackColor = normalColor;
            btnMaintenance.Font = normalFont;
            btnProfile.BackColor = normalColor;
            btnProfile.Font = normalFont;

            if (activeButton != null)
            {
                activeButton.BackColor = highlightColor;
                activeButton.Font = highlightFont;
            }
        }

        private void btnPaymentHistories_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPaymentHistories);
            SwitchUserControl(paymentHistoriesControl);
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            HighlightButton(btnFines);
            SwitchUserControl(finesControl);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMaintenance);
            SwitchUserControl(maintenanceControl);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }
    }
}
