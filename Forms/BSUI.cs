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

        public BSUI()
        {
            InitializeComponent();
        }

        public BSUI(
            User user,
            IEquipmentService equipmentService,
            IRequestService requestService)
            : this()
        {
            _currentUser = user
                ?? throw new ArgumentNullException(nameof(user));

            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            _requestService = requestService
                ?? throw new ArgumentNullException(nameof(requestService));
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
        }

        private void btnBrowseCatalog_Click(object sender, EventArgs e)
        {
            HighlightButton(btnBrowseCatalog);
        }

        private void btnMyRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnMyRequests);
        }

        private void btnFinesAndPenalties_Click(object sender, EventArgs e)
        {
            HighlightButton(btnFinesAndPenalties);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProfile);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
