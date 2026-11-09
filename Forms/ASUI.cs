using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using SanaPass_EBAAMS.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace SanaPass_EBAAMS
{
    public partial class ASUI : Form
    {
        private readonly IEquipmentService _equipmentService;
        private readonly IRequestService _requestService;
        private readonly IReportService _reportService;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly User _currentUser;

        public ASUI()
        {
            InitializeComponent();
        }
        public ASUI(
            IEquipmentService equipmentService,
            IRequestService requestService,
            IReportService reportService,
            IUserService userService,
            IUserRepository userRepository,
            User currentUser) : this()
        {
            _equipmentService =
                equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            _requestService =
                requestService
                ?? throw new ArgumentNullException(nameof(requestService));

            _reportService =
                reportService
                ?? throw new ArgumentNullException(nameof(reportService));

            _userService =
                userService
                ?? throw new ArgumentNullException(nameof(userService));

            _userRepository =
                userRepository
                ?? throw new ArgumentNullException(nameof(userRepository));

            _currentUser =
                currentUser
                ?? throw new ArgumentNullException(nameof(currentUser));
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
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
                    ADashboard dashboardControl = new ADashboard(_reportService);
                    SwitchUserControl(dashboardControl);
                    HighlightButton(btnDashboard);
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

        private void HighlightButton(Button activeButton)
        {
            Color normalColor = Color.Transparent;
            Color highlightColor = Color.FromArgb(180, 0, 0);
            Font normalFont = new Font(activeButton.Font, FontStyle.Regular);
            Font highlightFont = new Font(activeButton.Font, FontStyle.Bold);

            btnDashboard.BackColor = normalColor;
            btnDashboard.Font = normalFont;
            btnRequests.BackColor = normalColor;
            btnRequests.Font = normalFont;
            btnEquipments.BackColor = normalColor;
            btnEquipments.Font = normalFont;
            btnUsers.BackColor = normalColor;
            btnUsers.Font = normalFont;
            btnPaymentHistories.BackColor = normalColor;
            btnPaymentHistories.Font = normalFont;
            btnTransactionLogs.BackColor = normalColor;
            btnTransactionLogs.Font = normalFont;
            btnProfile.BackColor = normalColor;
            btnProfile.Font = normalFont;

            if (activeButton != null)
            {
                activeButton.BackColor = highlightColor;
                activeButton.Font = highlightFont;

            }
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            ADashboard dashboardControl = new ADashboard(_reportService);
            SwitchUserControl(dashboardControl);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnRequests);
            if (_requestService != null)
            {
                BorrowRequests borrowRequestsControl = new BorrowRequests(_requestService);
                SwitchUserControl(borrowRequestsControl);
            }
            else
            {
                MessageBox.Show("Request service is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            HighlightButton(btnEquipments);

            if (_equipmentService == null)
            {
                MessageBox.Show(
                    "Equipment service is not available.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            Equipments equipmentsControl = new Equipments(_equipmentService);
            SwitchUserControl(equipmentsControl);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HighlightButton(btnUsers);

            Users usersControl =
                new Users(_userRepository);

            SwitchUserControl(usersControl);
        }

        private void btnPaymentHistories_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPaymentHistories);
            PaymentHistories paymentHistoryControl = new PaymentHistories();
            SwitchUserControl(paymentHistoryControl);
        }

        private void btnTransactionLogs_Click(object sender, EventArgs e)
        {
            HighlightButton(btnTransactionLogs);
            TransactionLogs transactionLogsControl = new TransactionLogs();
            SwitchUserControl(transactionLogsControl);
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

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}