using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Forms
{
    public partial class BrowseCatalog : UserControl
    {
        private readonly IEquipmentService _equipmentService;

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvCatalog;
        private Label lblTitle;

        public BrowseCatalog()
        {
            InitializeInterface();
        }

        public BrowseCatalog(IEquipmentService equipmentService)
            : this()
        {
            _equipmentService = equipmentService
                ?? throw new ArgumentNullException(nameof(equipmentService));

            LoadCatalog();
        }

        private void InitializeInterface()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            lblTitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 55,
                Text = "Browse Equipment Catalog",
                Font = new Font(
                    "Microsoft Sans Serif",
                    20F,
                    FontStyle.Bold),
                ForeColor = Color.Maroon,
                Padding = new Padding(15, 10, 0, 0)
            };

            Panel searchPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                Padding = new Padding(15, 8, 15, 8)
            };

            txtSearch = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font(
                    "Microsoft Sans Serif",
                    11F),
                Text = "Search equipment..."
            };

            btnRefresh = new Button
            {
                Dock = DockStyle.Right,
                Width = 90,
                Text = "Refresh",
                BackColor = Color.White
            };

            btnSearch = new Button
            {
                Dock = DockStyle.Right,
                Width = 90,
                Text = "Search",
                BackColor = Color.White
            };

            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += txtSearch_KeyDown;

            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Controls.Add(btnRefresh);

            dgvCatalog = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                BackgroundColor = Color.White,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill
            };

            ConfigureGrid();

            Controls.Add(dgvCatalog);
            Controls.Add(searchPanel);
            Controls.Add(lblTitle);
        }

        private void ConfigureGrid()
        {
            dgvCatalog.Columns.Clear();

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "equipmentID",
                DataPropertyName = "equipmentID",
                HeaderText = "ID",
                Visible = false
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eName",
                DataPropertyName = "eName",
                HeaderText = "Equipment Name"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eDesc",
                DataPropertyName = "eDesc",
                HeaderText = "Description"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eStatus",
                DataPropertyName = "eStatus",
                HeaderText = "Status"
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ePrice",
                DataPropertyName = "ePrice",
                HeaderText = "Price",
                DefaultCellStyle =
                {
                    Format = "C2"
                }
            });

            dgvCatalog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "eCondition",
                DataPropertyName = "eCondition",
                HeaderText = "Condition"
            });
        }

        private void LoadCatalog()
        {
            if (_equipmentService == null)
            {
                return;
            }

            try
            {
                string keyword = txtSearch.Text.Trim();

                IEnumerable<Equipment> equipment =
                    _equipmentService.searchAvailableEquipment(keyword);

                dgvCatalog.DataSource = equipment
                    .Where(item =>
                        string.Equals(
                            item.eStatus,
                            "Available",
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load equipment catalog: {ex.Message}",
                    "Catalog Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            LoadCatalog();
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();
            LoadCatalog();
        }

        private void txtSearch_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadCatalog();
            }
        }

        private void txtBoxEquipmentSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
