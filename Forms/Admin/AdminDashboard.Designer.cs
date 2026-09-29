namespace SanaPass_EBAAMS
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnTransactionLogs = new System.Windows.Forms.Button();
            this.btnBorrowRequests = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.llblAdminName = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvRecentRequests = new System.Windows.Forms.DataGridView();
            this.colRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMaintenance = new System.Windows.Forms.Panel();
            this.lblMaintenanceNumber = new System.Windows.Forms.Label();
            this.lblMaintenanceTitle = new System.Windows.Forms.Label();
            this.pnlBorrowedEquipment = new System.Windows.Forms.Panel();
            this.lblNumberedBorrowed = new System.Windows.Forms.Label();
            this.lblBorrowedTitle = new System.Windows.Forms.Label();
            this.pnlPendingRequests = new System.Windows.Forms.Panel();
            this.lblPendingRequest = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pnlTotalEquipment = new System.Windows.Forms.Panel();
            this.lblTotalEquipment = new System.Windows.Forms.Label();
            this.lblTotalEquipmentTitle = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRequests)).BeginInit();
            this.pnlMaintenance.SuspendLayout();
            this.pnlBorrowedEquipment.SuspendLayout();
            this.pnlPendingRequests.SuspendLayout();
            this.pnlTotalEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnMaintenance);
            this.pnlSideBar.Controls.Add(this.btnTransactionLogs);
            this.pnlSideBar.Controls.Add(this.btnBorrowRequests);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.lblSystemName);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlSideBar.Size = new System.Drawing.Size(278, 715);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(14, 630);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(244, 56);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.Location = new System.Drawing.Point(13, 503);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(10);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Padding = new System.Windows.Forms.Padding(10);
            this.btnMaintenance.Size = new System.Drawing.Size(244, 56);
            this.btnMaintenance.TabIndex = 4;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            // 
            // btnTransactionLogs
            // 
            this.btnTransactionLogs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTransactionLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionLogs.FlatAppearance.BorderSize = 0;
            this.btnTransactionLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionLogs.Location = new System.Drawing.Point(13, 401);
            this.btnTransactionLogs.Margin = new System.Windows.Forms.Padding(10);
            this.btnTransactionLogs.Name = "btnTransactionLogs";
            this.btnTransactionLogs.Padding = new System.Windows.Forms.Padding(10);
            this.btnTransactionLogs.Size = new System.Drawing.Size(244, 56);
            this.btnTransactionLogs.TabIndex = 3;
            this.btnTransactionLogs.Text = "Transaction Logs";
            this.btnTransactionLogs.UseVisualStyleBackColor = false;
            // 
            // btnBorrowRequests
            // 
            this.btnBorrowRequests.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBorrowRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowRequests.FlatAppearance.BorderSize = 0;
            this.btnBorrowRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowRequests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowRequests.Location = new System.Drawing.Point(14, 294);
            this.btnBorrowRequests.Margin = new System.Windows.Forms.Padding(10);
            this.btnBorrowRequests.Name = "btnBorrowRequests";
            this.btnBorrowRequests.Padding = new System.Windows.Forms.Padding(10);
            this.btnBorrowRequests.Size = new System.Drawing.Size(244, 56);
            this.btnBorrowRequests.TabIndex = 2;
            this.btnBorrowRequests.Text = "Borrow Request";
            this.btnBorrowRequests.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(13, 177);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(244, 56);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(38, 22);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(172, 48);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "SanaPass";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.llblAdminName);
            this.pnlHeader.Controls.Add(this.lblDashboardTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(278, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 88);
            this.pnlHeader.TabIndex = 1;
            // 
            // llblAdminName
            // 
            this.llblAdminName.AutoSize = true;
            this.llblAdminName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAdminName.Location = new System.Drawing.Point(1118, 22);
            this.llblAdminName.Name = "llblAdminName";
            this.llblAdminName.Size = new System.Drawing.Size(70, 28);
            this.llblAdminName.TabIndex = 1;
            this.llblAdminName.Text = "Admin";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(7, 11);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(229, 54);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlContent.Controls.Add(this.dgvRecentRequests);
            this.pnlContent.Controls.Add(this.pnlMaintenance);
            this.pnlContent.Controls.Add(this.pnlBorrowedEquipment);
            this.pnlContent.Controls.Add(this.pnlPendingRequests);
            this.pnlContent.Controls.Add(this.pnlTotalEquipment);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(278, 88);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.pnlContent.Size = new System.Drawing.Size(1200, 627);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvRecentRequests
            // 
            this.dgvRecentRequests.AllowUserToAddRows = false;
            this.dgvRecentRequests.AllowUserToDeleteRows = false;
            this.dgvRecentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequestID,
            this.colStaffName,
            this.colEquipment,
            this.colDate,
            this.colStatus});
            this.dgvRecentRequests.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvRecentRequests.Location = new System.Drawing.Point(16, 259);
            this.dgvRecentRequests.MultiSelect = false;
            this.dgvRecentRequests.Name = "dgvRecentRequests";
            this.dgvRecentRequests.RowHeadersVisible = false;
            this.dgvRecentRequests.RowHeadersWidth = 62;
            this.dgvRecentRequests.RowTemplate.Height = 28;
            this.dgvRecentRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentRequests.Size = new System.Drawing.Size(1176, 354);
            this.dgvRecentRequests.TabIndex = 4;
            // 
            // colRequestID
            // 
            this.colRequestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRequestID.HeaderText = "Request ID";
            this.colRequestID.MinimumWidth = 8;
            this.colRequestID.Name = "colRequestID";
            // 
            // colStaffName
            // 
            this.colStaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffName.HeaderText = "Staff Name";
            this.colStaffName.MinimumWidth = 8;
            this.colStaffName.Name = "colStaffName";
            // 
            // colEquipment
            // 
            this.colEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEquipment.HeaderText = "Equipment";
            this.colEquipment.MinimumWidth = 8;
            this.colEquipment.Name = "colEquipment";
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            // 
            // pnlMaintenance
            // 
            this.pnlMaintenance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlMaintenance.Controls.Add(this.lblMaintenanceNumber);
            this.pnlMaintenance.Controls.Add(this.lblMaintenanceTitle);
            this.pnlMaintenance.Location = new System.Drawing.Point(914, 90);
            this.pnlMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMaintenance.Name = "pnlMaintenance";
            this.pnlMaintenance.Size = new System.Drawing.Size(278, 162);
            this.pnlMaintenance.TabIndex = 3;
            // 
            // lblMaintenanceNumber
            // 
            this.lblMaintenanceNumber.AutoSize = true;
            this.lblMaintenanceNumber.Location = new System.Drawing.Point(110, 69);
            this.lblMaintenanceNumber.Name = "lblMaintenanceNumber";
            this.lblMaintenanceNumber.Size = new System.Drawing.Size(22, 25);
            this.lblMaintenanceNumber.TabIndex = 7;
            this.lblMaintenanceNumber.Text = "3";
            // 
            // lblMaintenanceTitle
            // 
            this.lblMaintenanceTitle.AutoSize = true;
            this.lblMaintenanceTitle.Location = new System.Drawing.Point(112, 28);
            this.lblMaintenanceTitle.Name = "lblMaintenanceTitle";
            this.lblMaintenanceTitle.Size = new System.Drawing.Size(112, 25);
            this.lblMaintenanceTitle.TabIndex = 6;
            this.lblMaintenanceTitle.Text = "Maintenance";
            // 
            // pnlBorrowedEquipment
            // 
            this.pnlBorrowedEquipment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBorrowedEquipment.Controls.Add(this.lblNumberedBorrowed);
            this.pnlBorrowedEquipment.Controls.Add(this.lblBorrowedTitle);
            this.pnlBorrowedEquipment.Location = new System.Drawing.Point(623, 90);
            this.pnlBorrowedEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBorrowedEquipment.Name = "pnlBorrowedEquipment";
            this.pnlBorrowedEquipment.Size = new System.Drawing.Size(278, 162);
            this.pnlBorrowedEquipment.TabIndex = 2;
            // 
            // lblNumberedBorrowed
            // 
            this.lblNumberedBorrowed.AutoSize = true;
            this.lblNumberedBorrowed.Location = new System.Drawing.Point(110, 69);
            this.lblNumberedBorrowed.Name = "lblNumberedBorrowed";
            this.lblNumberedBorrowed.Size = new System.Drawing.Size(32, 25);
            this.lblNumberedBorrowed.TabIndex = 5;
            this.lblNumberedBorrowed.Text = "15";
            // 
            // lblBorrowedTitle
            // 
            this.lblBorrowedTitle.AutoSize = true;
            this.lblBorrowedTitle.Location = new System.Drawing.Point(135, 28);
            this.lblBorrowedTitle.Name = "lblBorrowedTitle";
            this.lblBorrowedTitle.Size = new System.Drawing.Size(89, 25);
            this.lblBorrowedTitle.TabIndex = 4;
            this.lblBorrowedTitle.Text = "Borrowed";
            // 
            // pnlPendingRequests
            // 
            this.pnlPendingRequests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlPendingRequests.Controls.Add(this.lblPendingRequest);
            this.pnlPendingRequests.Controls.Add(this.lblPendingTitle);
            this.pnlPendingRequests.Location = new System.Drawing.Point(321, 88);
            this.pnlPendingRequests.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPendingRequests.Name = "pnlPendingRequests";
            this.pnlPendingRequests.Size = new System.Drawing.Size(278, 162);
            this.pnlPendingRequests.TabIndex = 1;
            // 
            // lblPendingRequest
            // 
            this.lblPendingRequest.AutoSize = true;
            this.lblPendingRequest.Location = new System.Drawing.Point(110, 69);
            this.lblPendingRequest.Name = "lblPendingRequest";
            this.lblPendingRequest.Size = new System.Drawing.Size(22, 25);
            this.lblPendingRequest.TabIndex = 3;
            this.lblPendingRequest.Text = "8";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Location = new System.Drawing.Point(129, 30);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(76, 25);
            this.lblPendingTitle.TabIndex = 2;
            this.lblPendingTitle.Text = "Pending";
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalEquipment
            // 
            this.pnlTotalEquipment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTotalEquipment.Controls.Add(this.lblTotalEquipment);
            this.pnlTotalEquipment.Controls.Add(this.lblTotalEquipmentTitle);
            this.pnlTotalEquipment.Location = new System.Drawing.Point(17, 88);
            this.pnlTotalEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTotalEquipment.Name = "pnlTotalEquipment";
            this.pnlTotalEquipment.Size = new System.Drawing.Size(278, 162);
            this.pnlTotalEquipment.TabIndex = 0;
            // 
            // lblTotalEquipment
            // 
            this.lblTotalEquipment.AutoSize = true;
            this.lblTotalEquipment.Location = new System.Drawing.Point(95, 76);
            this.lblTotalEquipment.Name = "lblTotalEquipment";
            this.lblTotalEquipment.Size = new System.Drawing.Size(32, 25);
            this.lblTotalEquipment.TabIndex = 1;
            this.lblTotalEquipment.Text = "50";
            // 
            // lblTotalEquipmentTitle
            // 
            this.lblTotalEquipmentTitle.AutoSize = true;
            this.lblTotalEquipmentTitle.Location = new System.Drawing.Point(95, 17);
            this.lblTotalEquipmentTitle.Name = "lblTotalEquipmentTitle";
            this.lblTotalEquipmentTitle.Size = new System.Drawing.Size(98, 25);
            this.lblTotalEquipmentTitle.TabIndex = 0;
            this.lblTotalEquipmentTitle.Text = "Equipment";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1478, 715);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRequests)).EndInit();
            this.pnlMaintenance.ResumeLayout(false);
            this.pnlMaintenance.PerformLayout();
            this.pnlBorrowedEquipment.ResumeLayout(false);
            this.pnlBorrowedEquipment.PerformLayout();
            this.pnlPendingRequests.ResumeLayout(false);
            this.pnlPendingRequests.PerformLayout();
            this.pnlTotalEquipment.ResumeLayout(false);
            this.pnlTotalEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnTransactionLogs;
        private System.Windows.Forms.Button btnBorrowRequests;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label llblAdminName;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlPendingRequests;
        private System.Windows.Forms.Panel pnlTotalEquipment;
        private System.Windows.Forms.Panel pnlMaintenance;
        private System.Windows.Forms.Panel pnlBorrowedEquipment;
        private System.Windows.Forms.Label lblMaintenanceNumber;
        private System.Windows.Forms.Label lblMaintenanceTitle;
        private System.Windows.Forms.Label lblNumberedBorrowed;
        private System.Windows.Forms.Label lblBorrowedTitle;
        private System.Windows.Forms.Label lblPendingRequest;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblTotalEquipment;
        private System.Windows.Forms.Label lblTotalEquipmentTitle;
        private System.Windows.Forms.DataGridView dgvRecentRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}