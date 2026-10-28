using SanaPass_EBAAMS.Interfaces;
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
    public partial class BorrowRequests : UserControl
    {
        private readonly IRequestService _requestService;

        // 1. Default parameterless constructor required by the Visual Studio Designer
        public BorrowRequests()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
        }

        // 2. Dependency Injection constructor used by ASUI to pass the service
        public BorrowRequests(IRequestService requestService) : this()
        {
            _requestService = requestService;
            LoadBorrowRequests();
        }

        private void BorrowRequests_Load(object sender, EventArgs e)
        {
            // Safety fallback if loaded via designer/parameterless constructor
            if (_requestService != null)
            {
                LoadBorrowRequests();
            }
        }

        private void LoadBorrowRequests()
        {
            try
            {
                // TODO: Fetch your request data and bind it to your DataGridView (e.g., dgvRequests)
                // var requests = _requestService.GetAllRequests();
                // dgvRequests.DataSource = requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading requests: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrowRequests_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvARequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SetupDataGridViewColumns()
        {
            dgvARequests.Columns.Clear();
            dgvARequests.AutoGenerateColumns = false;

            // Define columns manually for precise control
            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "RequestID",
                DataPropertyName = "RequestID",
                HeaderText = "ID",
                Width = 60,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "BorrowerName",
                DataPropertyName = "BorrowerName",
                HeaderText = "Borrower",
                Width = 150,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "EquipmentName",
                DataPropertyName = "EquipmentName",
                HeaderText = "Equipment",
                Width = 180,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = "Qty",
                Width = 60,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "RequestDate",
                DataPropertyName = "RequestDate",
                HeaderText = "Date Requested",
                Width = 120,
                ReadOnly = true
            });

            dgvARequests.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 100,
                ReadOnly = true
            });
        }
    }
}
