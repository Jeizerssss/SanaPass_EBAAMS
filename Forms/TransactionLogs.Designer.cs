namespace SanaPass_EBAAMS.Forms
{
    partial class TransactionLogs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogsTop = new System.Windows.Forms.Panel();
            this.cmbLogsFilter = new System.Windows.Forms.ComboBox();
            this.btnARefreshTransactionLogs = new System.Windows.Forms.Button();
            this.lblTransactionLogs = new System.Windows.Forms.Label();
            this.txtBoxLogSearch = new System.Windows.Forms.TextBox();
            this.pnlLogsBottom = new System.Windows.Forms.Panel();
            this.btnPaymentHistoriesExport = new System.Windows.Forms.Button();
            this.btnPaymentDetails = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactionLogs = new System.Windows.Forms.DataGridView();
            this.pnlLogsTop.SuspendLayout();
            this.pnlLogsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogsTop
            // 
            this.pnlLogsTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlLogsTop.Controls.Add(this.cmbLogsFilter);
            this.pnlLogsTop.Controls.Add(this.btnARefreshTransactionLogs);
            this.pnlLogsTop.Controls.Add(this.lblTransactionLogs);
            this.pnlLogsTop.Controls.Add(this.txtBoxLogSearch);
            this.pnlLogsTop.Location = new System.Drawing.Point(3, 3);
            this.pnlLogsTop.Name = "pnlLogsTop";
            this.pnlLogsTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlLogsTop.TabIndex = 7;
            // 
            // cmbLogsFilter
            // 
            this.cmbLogsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLogsFilter.FormattingEnabled = true;
            this.cmbLogsFilter.Location = new System.Drawing.Point(769, 35);
            this.cmbLogsFilter.Name = "cmbLogsFilter";
            this.cmbLogsFilter.Size = new System.Drawing.Size(146, 32);
            this.cmbLogsFilter.TabIndex = 3;
            this.cmbLogsFilter.Text = "All Histories";
            // 
            // btnARefreshTransactionLogs
            // 
            this.btnARefreshTransactionLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshTransactionLogs.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshTransactionLogs.Name = "btnARefreshTransactionLogs";
            this.btnARefreshTransactionLogs.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshTransactionLogs.TabIndex = 2;
            this.btnARefreshTransactionLogs.Text = "Refresh";
            this.btnARefreshTransactionLogs.UseVisualStyleBackColor = true;
            // 
            // lblTransactionLogs
            // 
            this.lblTransactionLogs.AutoSize = true;
            this.lblTransactionLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionLogs.ForeColor = System.Drawing.Color.White;
            this.lblTransactionLogs.Location = new System.Drawing.Point(24, 28);
            this.lblTransactionLogs.Name = "lblTransactionLogs";
            this.lblTransactionLogs.Size = new System.Drawing.Size(385, 39);
            this.lblTransactionLogs.TabIndex = 0;
            this.lblTransactionLogs.Text = "TRANSACTION LOGS";
            // 
            // txtBoxLogSearch
            // 
            this.txtBoxLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxLogSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxLogSearch.Name = "txtBoxLogSearch";
            this.txtBoxLogSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxLogSearch.TabIndex = 1;
            this.txtBoxLogSearch.Text = "Enter search";
            // 
            // pnlLogsBottom
            // 
            this.pnlLogsBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlLogsBottom.Controls.Add(this.btnPaymentHistoriesExport);
            this.pnlLogsBottom.Controls.Add(this.btnPaymentDetails);
            this.pnlLogsBottom.Controls.Add(this.lblDate);
            this.pnlLogsBottom.Controls.Add(this.label1);
            this.pnlLogsBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlLogsBottom.Name = "pnlLogsBottom";
            this.pnlLogsBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlLogsBottom.TabIndex = 9;
            // 
            // btnPaymentHistoriesExport
            // 
            this.btnPaymentHistoriesExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentHistoriesExport.Location = new System.Drawing.Point(779, 25);
            this.btnPaymentHistoriesExport.Name = "btnPaymentHistoriesExport";
            this.btnPaymentHistoriesExport.Size = new System.Drawing.Size(113, 35);
            this.btnPaymentHistoriesExport.TabIndex = 5;
            this.btnPaymentHistoriesExport.Text = "Export";
            this.btnPaymentHistoriesExport.UseVisualStyleBackColor = true;
            // 
            // btnPaymentDetails
            // 
            this.btnPaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentDetails.Location = new System.Drawing.Point(898, 25);
            this.btnPaymentDetails.Name = "btnPaymentDetails";
            this.btnPaymentDetails.Size = new System.Drawing.Size(113, 35);
            this.btnPaymentDetails.TabIndex = 4;
            this.btnPaymentDetails.Text = "Details";
            this.btnPaymentDetails.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(141, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(163, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last checked:";
            // 
            // dgvTransactionLogs
            // 
            this.dgvTransactionLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTransactionLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionLogs.Location = new System.Drawing.Point(3, 109);
            this.dgvTransactionLogs.Name = "dgvTransactionLogs";
            this.dgvTransactionLogs.RowHeadersWidth = 51;
            this.dgvTransactionLogs.Size = new System.Drawing.Size(1045, 510);
            this.dgvTransactionLogs.TabIndex = 10;
            // 
            // TransactionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTransactionLogs);
            this.Controls.Add(this.pnlLogsBottom);
            this.Controls.Add(this.pnlLogsTop);
            this.Name = "TransactionLogs";
            this.Size = new System.Drawing.Size(1051, 714);
            this.pnlLogsTop.ResumeLayout(false);
            this.pnlLogsTop.PerformLayout();
            this.pnlLogsBottom.ResumeLayout(false);
            this.pnlLogsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogsTop;
        private System.Windows.Forms.ComboBox cmbLogsFilter;
        private System.Windows.Forms.Button btnARefreshTransactionLogs;
        private System.Windows.Forms.Label lblTransactionLogs;
        private System.Windows.Forms.TextBox txtBoxLogSearch;
        private System.Windows.Forms.Panel pnlLogsBottom;
        private System.Windows.Forms.Button btnPaymentHistoriesExport;
        private System.Windows.Forms.Button btnPaymentDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransactionLogs;
    }
}
