using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using SanaPass_EBAAMS.DataRepo;
using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using SanaPass_EBAAMS.Services;

namespace SanaPass_EBAAMS.Forms
{
    public partial class Fines : UserControl
    {
        private readonly IFineRepository _fineRepository;
        private readonly IFineService _fineService;
        private readonly int _handledBy;
        private readonly int? _borrowerID;
        private List<Fine> _fines = new List<Fine>();

        public Fines()
            : this(0, null)
        {
        }

        public Fines(int handledBy, int? borrowerID)
        {
            InitializeComponent();
            _handledBy = handledBy;
            _borrowerID = borrowerID;
            var requestRepository = new RequestRepository();
            _fineRepository = new FineRepository();
            _fineService = new FineService(
                _fineRepository,
                requestRepository,
                new PaymentHistoryRepository(),
                new TransactionLogRepository());
            SetupFinesGrid();
            btnARefreshFines.Click += btnARefreshFines_Click;
            btnARequestDetails.Click += btnARequestDetails_Click;
            btnSettleFine.Click += btnSettleFine_Click;
            txtBoxAFinesSearch.TextChanged += txtBoxAFinesSearch_TextChanged;
            cmbAFilterStatus.SelectedIndexChanged += txtBoxAFinesSearch_TextChanged;
            cmbAFilterStatus.Items.AddRange(new object[] { "All", "Unpaid", "Partial", "Paid" });
            cmbAFilterStatus.SelectedIndex = 0;
            btnSettleFine.Visible = handledBy > 0;
            LoadFinesData();
        }

        private void Fines_Load(object sender, EventArgs e)
        {
        }

        private void SetupFinesGrid()
        {
            dgvAFines.Columns.Clear();
            dgvAFines.AutoGenerateColumns = false;

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineID", DataPropertyName = "fineID", HeaderText = "Fine ID", Width = 60, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "requestID", DataPropertyName = "requestID", HeaderText = "Request ID", Width = 100, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "amount", DataPropertyName = "amount", HeaderText = "Amount", Width = 110, ReadOnly = true, DefaultCellStyle = { Format = "C2" } });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fDate", DataPropertyName = "fDate", HeaderText = "Date Issued", Width = 130, ReadOnly = true });

            dgvAFines.Columns.Add(new DataGridViewTextBoxColumn()
            { Name = "fineStatus", DataPropertyName = "fineStatus", HeaderText = "Status", Width = 100, ReadOnly = true });

            dgvAFines.ReadOnly = true;
            dgvAFines.AllowUserToAddRows = false;
            dgvAFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAFines.MultiSelect = false;
        }

        private void btnSettleFine_Click(object sender, EventArgs e)
        {
            if (dgvAFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a fine record to settle.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Fine selectedFine = dgvAFines.SelectedRows[0].DataBoundItem as Fine;
            if (selectedFine == null)
            {
                MessageBox.Show("The selected fine is invalid.", "Fine Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Mark this fine as paid and record the transaction?",
                "Confirm Settlement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool paid = _fineService.processFinePayment(
                        selectedFine.requestID,
                        selectedFine.amount,
                        "Cash",
                        _handledBy);

                    if (!paid)
                    {
                        MessageBox.Show("The payment could not be recorded.", "Payment Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    LoadFinesData();
                    MessageBox.Show("Fine payment recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to record the payment: {ex.Message}", "Payment Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFinesData()
        {
            try
            {
                _fines = _fineRepository.getAll().ToList();
                if (_borrowerID.HasValue)
                {
                    var requestIDs = new HashSet<int>(new RequestRepository()
                        .getByUserId(_borrowerID.Value)
                        .Select(request => request.requestID));
                    _fines = _fines.Where(fine => requestIDs.Contains(fine.requestID)).ToList();
                }

                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load fines: {ex.Message}", "Fine List Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            if (dgvAFines == null) return;
            string search = txtBoxAFinesSearch.Text.Trim();
            if (search == "Enter search") search = string.Empty;
            string status = cmbAFilterStatus.SelectedItem as string;

            dgvAFines.DataSource = _fines.Where(fine =>
                (string.IsNullOrEmpty(search) || fine.fineID.ToString().Contains(search) ||
                 fine.requestID.ToString().Contains(search) || fine.amount.ToString().Contains(search)) &&
                (string.IsNullOrEmpty(status) || status == "All" || fine.fineStatus == status))
                .ToList();
        }

        private void btnARefreshFines_Click(object sender, EventArgs e)
        {
            LoadFinesData();
        }

        private void txtBoxAFinesSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnARequestDetails_Click(object sender, EventArgs e)
        {
            Fine fine = dgvAFines.CurrentRow?.DataBoundItem as Fine;
            if (fine == null)
            {
                MessageBox.Show("Select a fine record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Fine #{fine.fineID}\nRequest: {fine.requestID}\nAmount: {fine.amount:C2}\n" +
                $"Issued: {fine.fDate:g}\nStatus: {fine.fineStatus}",
                "Fine Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}