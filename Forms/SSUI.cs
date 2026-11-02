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
        public SSUI()
        {
            InitializeComponent();
        }
        public SSUI(
            IEquipmentService equipmentService,
            IRequestService requestService,
            IUserService userService,
            User currentUser) : this()
        {
            _equipmentService = equipmentService;
            _requestService = requestService;
            _userService = userService;
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
                    BorrowRequests requestsControl = new BorrowRequests(_requestService);
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
            SwitchUserControl(new Equipments(_equipmentService));
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRequests);
            SwitchUserControl(new BorrowRequests(_requestService));
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
            SwitchUserControl(new PaymentHistories());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            HighlightButton(btnFines);
            SwitchUserControl(new Fines(_currentUser.userID, null));
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMaintenance);
            SwitchUserControl(new Maintenance());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ReturnToLogin();
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

        private void ReturnToLogin()
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
