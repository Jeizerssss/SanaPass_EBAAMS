namespace SanaPass_EBAAMS.Forms
{
    partial class PaymentHistories
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
            this.pnlPaymentTop = new System.Windows.Forms.Panel();
            this.cmbPaymentFilter = new System.Windows.Forms.ComboBox();
            this.btnARefreshPaymentHistories = new System.Windows.Forms.Button();
            this.lblPaymentHistories = new System.Windows.Forms.Label();
            this.txtBoxPaymentSearch = new System.Windows.Forms.TextBox();
            this.pnlPaymentBottom = new System.Windows.Forms.Panel();
            this.btnPaymentDetails = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPaymentHistory = new System.Windows.Forms.DataGridView();
            this.btnPaymentHistoriesExport = new System.Windows.Forms.Button();
            this.pnlPaymentTop.SuspendLayout();
            this.pnlPaymentBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPaymentTop
            // 
            this.pnlPaymentTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlPaymentTop.Controls.Add(this.cmbPaymentFilter);
            this.pnlPaymentTop.Controls.Add(this.btnARefreshPaymentHistories);
            this.pnlPaymentTop.Controls.Add(this.lblPaymentHistories);
            this.pnlPaymentTop.Controls.Add(this.txtBoxPaymentSearch);
            this.pnlPaymentTop.Location = new System.Drawing.Point(3, 3);
            this.pnlPaymentTop.Name = "pnlPaymentTop";
            this.pnlPaymentTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlPaymentTop.TabIndex = 6;
            // 
            // cmbPaymentFilter
            // 
            this.cmbPaymentFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentFilter.FormattingEnabled = true;
            this.cmbPaymentFilter.Location = new System.Drawing.Point(769, 35);
            this.cmbPaymentFilter.Name = "cmbPaymentFilter";
            this.cmbPaymentFilter.Size = new System.Drawing.Size(146, 32);
            this.cmbPaymentFilter.TabIndex = 3;
            this.cmbPaymentFilter.Text = "All Histories";
            // 
            // btnARefreshPaymentHistories
            // 
            this.btnARefreshPaymentHistories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshPaymentHistories.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshPaymentHistories.Name = "btnARefreshPaymentHistories";
            this.btnARefreshPaymentHistories.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshPaymentHistories.TabIndex = 2;
            this.btnARefreshPaymentHistories.Text = "Refresh";
            this.btnARefreshPaymentHistories.UseVisualStyleBackColor = true;
            // 
            // lblPaymentHistories
            // 
            this.lblPaymentHistories.AutoSize = true;
            this.lblPaymentHistories.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentHistories.ForeColor = System.Drawing.Color.White;
            this.lblPaymentHistories.Location = new System.Drawing.Point(24, 28);
            this.lblPaymentHistories.Name = "lblPaymentHistories";
            this.lblPaymentHistories.Size = new System.Drawing.Size(395, 39);
            this.lblPaymentHistories.TabIndex = 0;
            this.lblPaymentHistories.Text = "PAYMENT HISTORIES";
            // 
            // txtBoxPaymentSearch
            // 
            this.txtBoxPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPaymentSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxPaymentSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxPaymentSearch.Name = "txtBoxPaymentSearch";
            this.txtBoxPaymentSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxPaymentSearch.TabIndex = 1;
            this.txtBoxPaymentSearch.Text = "Enter search";
            // 
            // pnlPaymentBottom
            // 
            this.pnlPaymentBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlPaymentBottom.Controls.Add(this.btnPaymentHistoriesExport);
            this.pnlPaymentBottom.Controls.Add(this.btnPaymentDetails);
            this.pnlPaymentBottom.Controls.Add(this.lblDate);
            this.pnlPaymentBottom.Controls.Add(this.label1);
            this.pnlPaymentBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlPaymentBottom.Name = "pnlPaymentBottom";
            this.pnlPaymentBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlPaymentBottom.TabIndex = 8;
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
            this.lblDate.Location = new System.Drawing.Point(183, 31);
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
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last checked as of:";
            // 
            // dgvPaymentHistory
            // 
            this.dgvPaymentHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentHistory.Location = new System.Drawing.Point(3, 109);
            this.dgvPaymentHistory.Name = "dgvPaymentHistory";
            this.dgvPaymentHistory.RowHeadersWidth = 51;
            this.dgvPaymentHistory.Size = new System.Drawing.Size(1045, 510);
            this.dgvPaymentHistory.TabIndex = 9;
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
            // PaymentHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPaymentHistory);
            this.Controls.Add(this.pnlPaymentBottom);
            this.Controls.Add(this.pnlPaymentTop);
            this.Name = "PaymentHistories";
            this.Size = new System.Drawing.Size(1051, 714);
            this.pnlPaymentTop.ResumeLayout(false);
            this.pnlPaymentTop.PerformLayout();
            this.pnlPaymentBottom.ResumeLayout(false);
            this.pnlPaymentBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaymentTop;
        private System.Windows.Forms.ComboBox cmbPaymentFilter;
        private System.Windows.Forms.Button btnARefreshPaymentHistories;
        private System.Windows.Forms.Label lblPaymentHistories;
        private System.Windows.Forms.TextBox txtBoxPaymentSearch;
        private System.Windows.Forms.Panel pnlPaymentBottom;
        private System.Windows.Forms.Button btnPaymentDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPaymentHistory;
        private System.Windows.Forms.Button btnPaymentHistoriesExport;
    }
}
