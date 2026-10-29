namespace SanaPass_EBAAMS.Forms
{
    partial class BorrowRequests
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblARequest = new System.Windows.Forms.Label();
            this.txtBoxARequestSearch = new System.Windows.Forms.TextBox();
            this.pnlARequestTop = new System.Windows.Forms.Panel();
            this.cmbAFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnARefreshRequest = new System.Windows.Forms.Button();
            this.dgvARequests = new System.Windows.Forms.DataGridView();
            this.pnlARequestBottom = new System.Windows.Forms.Panel();
            this.btnARequestDetails = new System.Windows.Forms.Button();
            this.btnAReturnAll = new System.Windows.Forms.Button();
            this.btnAApproveAll = new System.Windows.Forms.Button();
            this.lblATotalRequest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlARequestTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARequests)).BeginInit();
            this.pnlARequestBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblARequest
            // 
            this.lblARequest.AutoSize = true;
            this.lblARequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARequest.ForeColor = System.Drawing.Color.White;
            this.lblARequest.Location = new System.Drawing.Point(20, 22);
            this.lblARequest.Name = "lblARequest";
            this.lblARequest.Size = new System.Drawing.Size(296, 55);
            this.lblARequest.TabIndex = 0;
            this.lblARequest.Text = "REQUESTS";
            this.lblARequest.Click += new System.EventHandler(this.lblARequest_Click);
            // 
            // txtBoxARequestSearch
            // 
            this.txtBoxARequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxARequestSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxARequestSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxARequestSearch.Name = "txtBoxARequestSearch";
            this.txtBoxARequestSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxARequestSearch.TabIndex = 1;
            this.txtBoxARequestSearch.Text = "Enter search";
            this.txtBoxARequestSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlARequestTop
            // 
            this.pnlARequestTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlARequestTop.Controls.Add(this.cmbAFilterStatus);
            this.pnlARequestTop.Controls.Add(this.btnARefreshRequest);
            this.pnlARequestTop.Controls.Add(this.lblARequest);
            this.pnlARequestTop.Controls.Add(this.txtBoxARequestSearch);
            this.pnlARequestTop.Location = new System.Drawing.Point(3, 3);
            this.pnlARequestTop.Name = "pnlARequestTop";
            this.pnlARequestTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlARequestTop.TabIndex = 2;
            // 
            // cmbAFilterStatus
            // 
            this.cmbAFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAFilterStatus.FormattingEnabled = true;
            this.cmbAFilterStatus.Location = new System.Drawing.Point(769, 35);
            this.cmbAFilterStatus.Name = "cmbAFilterStatus";
            this.cmbAFilterStatus.Size = new System.Drawing.Size(146, 32);
            this.cmbAFilterStatus.TabIndex = 3;
            this.cmbAFilterStatus.Text = "All";
            // 
            // btnARefreshRequest
            // 
            this.btnARefreshRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshRequest.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshRequest.Name = "btnARefreshRequest";
            this.btnARefreshRequest.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshRequest.TabIndex = 2;
            this.btnARefreshRequest.Text = "Refresh";
            this.btnARefreshRequest.UseVisualStyleBackColor = true;
            // 
            // dgvARequests
            // 
            this.dgvARequests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvARequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvARequests.Location = new System.Drawing.Point(3, 109);
            this.dgvARequests.Name = "dgvARequests";
            this.dgvARequests.RowHeadersWidth = 51;
            this.dgvARequests.Size = new System.Drawing.Size(1045, 510);
            this.dgvARequests.TabIndex = 3;
            this.dgvARequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvARequests_CellContentClick);
            // 
            // pnlARequestBottom
            // 
            this.pnlARequestBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlARequestBottom.Controls.Add(this.btnARequestDetails);
            this.pnlARequestBottom.Controls.Add(this.btnAReturnAll);
            this.pnlARequestBottom.Controls.Add(this.btnAApproveAll);
            this.pnlARequestBottom.Controls.Add(this.lblATotalRequest);
            this.pnlARequestBottom.Controls.Add(this.label1);
            this.pnlARequestBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlARequestBottom.Name = "pnlARequestBottom";
            this.pnlARequestBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlARequestBottom.TabIndex = 4;
            // 
            // btnARequestDetails
            // 
            this.btnARequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARequestDetails.Location = new System.Drawing.Point(898, 25);
            this.btnARequestDetails.Name = "btnARequestDetails";
            this.btnARequestDetails.Size = new System.Drawing.Size(113, 35);
            this.btnARequestDetails.TabIndex = 4;
            this.btnARequestDetails.Text = "Details";
            this.btnARequestDetails.UseVisualStyleBackColor = true;
            // 
            // btnAReturnAll
            // 
            this.btnAReturnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAReturnAll.Location = new System.Drawing.Point(779, 25);
            this.btnAReturnAll.Name = "btnAReturnAll";
            this.btnAReturnAll.Size = new System.Drawing.Size(113, 35);
            this.btnAReturnAll.TabIndex = 3;
            this.btnAReturnAll.Text = "Return All";
            this.btnAReturnAll.UseVisualStyleBackColor = true;
            // 
            // btnAApproveAll
            // 
            this.btnAApproveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAApproveAll.Location = new System.Drawing.Point(651, 25);
            this.btnAApproveAll.Name = "btnAApproveAll";
            this.btnAApproveAll.Size = new System.Drawing.Size(122, 35);
            this.btnAApproveAll.TabIndex = 2;
            this.btnAApproveAll.Text = "Approve All";
            this.btnAApproveAll.UseVisualStyleBackColor = true;
            // 
            // lblATotalRequest
            // 
            this.lblATotalRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotalRequest.ForeColor = System.Drawing.Color.White;
            this.lblATotalRequest.Location = new System.Drawing.Point(154, 31);
            this.lblATotalRequest.Name = "lblATotalRequest";
            this.lblATotalRequest.Size = new System.Drawing.Size(163, 23);
            this.lblATotalRequest.TabIndex = 1;
            this.lblATotalRequest.Text = "0";
            this.lblATotalRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblATotalRequest.Click += new System.EventHandler(this.lblATotalRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Requests:";
            // 
            // BorrowRequests
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlARequestBottom);
            this.Controls.Add(this.dgvARequests);
            this.Controls.Add(this.pnlARequestTop);
            this.Name = "BorrowRequests";
            this.Size = new System.Drawing.Size(1051, 714);
            this.Load += new System.EventHandler(this.BorrowRequests_Load_1);
            this.pnlARequestTop.ResumeLayout(false);
            this.pnlARequestTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARequests)).EndInit();
            this.pnlARequestBottom.ResumeLayout(false);
            this.pnlARequestBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblARequest;
        private System.Windows.Forms.TextBox txtBoxARequestSearch;
        private System.Windows.Forms.Panel pnlARequestTop;
        private System.Windows.Forms.DataGridView dgvARequests;
        private System.Windows.Forms.ComboBox cmbAFilterStatus;
        private System.Windows.Forms.Button btnARefreshRequest;
        private System.Windows.Forms.Panel pnlARequestBottom;
        private System.Windows.Forms.Button btnAApproveAll;
        private System.Windows.Forms.Label lblATotalRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnARequestDetails;
        private System.Windows.Forms.Button btnAReturnAll;
    }
}
