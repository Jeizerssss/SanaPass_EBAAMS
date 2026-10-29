namespace SanaPass_EBAAMS.Forms
{
    partial class Fines
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
            this.pnlAFinesTop = new System.Windows.Forms.Panel();
            this.cmbAFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnARefreshFines = new System.Windows.Forms.Button();
            this.lblAFines = new System.Windows.Forms.Label();
            this.txtBoxAFinesSearch = new System.Windows.Forms.TextBox();
            this.pnlAFinesBottom = new System.Windows.Forms.Panel();
            this.btnARequestDetails = new System.Windows.Forms.Button();
            this.btnAReturnAll = new System.Windows.Forms.Button();
            this.btnAApproveAll = new System.Windows.Forms.Button();
            this.lblALastChecked = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAFines = new System.Windows.Forms.DataGridView();
            this.pnlAFinesTop.SuspendLayout();
            this.pnlAFinesBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFines)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAFinesTop
            // 
            this.pnlAFinesTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlAFinesTop.Controls.Add(this.cmbAFilterStatus);
            this.pnlAFinesTop.Controls.Add(this.btnARefreshFines);
            this.pnlAFinesTop.Controls.Add(this.lblAFines);
            this.pnlAFinesTop.Controls.Add(this.txtBoxAFinesSearch);
            this.pnlAFinesTop.Location = new System.Drawing.Point(3, 3);
            this.pnlAFinesTop.Name = "pnlAFinesTop";
            this.pnlAFinesTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlAFinesTop.TabIndex = 3;
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
            // btnARefreshFines
            // 
            this.btnARefreshFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshFines.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshFines.Name = "btnARefreshFines";
            this.btnARefreshFines.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshFines.TabIndex = 2;
            this.btnARefreshFines.Text = "Refresh";
            this.btnARefreshFines.UseVisualStyleBackColor = true;
            // 
            // lblAFines
            // 
            this.lblAFines.AutoSize = true;
            this.lblAFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFines.ForeColor = System.Drawing.Color.White;
            this.lblAFines.Location = new System.Drawing.Point(20, 22);
            this.lblAFines.Name = "lblAFines";
            this.lblAFines.Size = new System.Drawing.Size(170, 55);
            this.lblAFines.TabIndex = 0;
            this.lblAFines.Text = "FINES";
            // 
            // txtBoxAFinesSearch
            // 
            this.txtBoxAFinesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAFinesSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxAFinesSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxAFinesSearch.Name = "txtBoxAFinesSearch";
            this.txtBoxAFinesSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxAFinesSearch.TabIndex = 1;
            this.txtBoxAFinesSearch.Text = "Enter search";
            // 
            // pnlAFinesBottom
            // 
            this.pnlAFinesBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlAFinesBottom.Controls.Add(this.btnARequestDetails);
            this.pnlAFinesBottom.Controls.Add(this.btnAReturnAll);
            this.pnlAFinesBottom.Controls.Add(this.btnAApproveAll);
            this.pnlAFinesBottom.Controls.Add(this.lblALastChecked);
            this.pnlAFinesBottom.Controls.Add(this.label1);
            this.pnlAFinesBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlAFinesBottom.Name = "pnlAFinesBottom";
            this.pnlAFinesBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlAFinesBottom.TabIndex = 5;
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
            // lblALastChecked
            // 
            this.lblALastChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALastChecked.ForeColor = System.Drawing.Color.White;
            this.lblALastChecked.Location = new System.Drawing.Point(141, 31);
            this.lblALastChecked.Name = "lblALastChecked";
            this.lblALastChecked.Size = new System.Drawing.Size(163, 23);
            this.lblALastChecked.TabIndex = 1;
            this.lblALastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dgvAFines
            // 
            this.dgvAFines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFines.Location = new System.Drawing.Point(3, 109);
            this.dgvAFines.Name = "dgvAFines";
            this.dgvAFines.RowHeadersWidth = 51;
            this.dgvAFines.Size = new System.Drawing.Size(1045, 510);
            this.dgvAFines.TabIndex = 6;
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAFines);
            this.Controls.Add(this.pnlAFinesBottom);
            this.Controls.Add(this.pnlAFinesTop);
            this.Name = "Fines";
            this.Size = new System.Drawing.Size(1051, 714);
            this.pnlAFinesTop.ResumeLayout(false);
            this.pnlAFinesTop.PerformLayout();
            this.pnlAFinesBottom.ResumeLayout(false);
            this.pnlAFinesBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAFinesTop;
        private System.Windows.Forms.ComboBox cmbAFilterStatus;
        private System.Windows.Forms.Button btnARefreshFines;
        private System.Windows.Forms.Label lblAFines;
        private System.Windows.Forms.TextBox txtBoxAFinesSearch;
        private System.Windows.Forms.Panel pnlAFinesBottom;
        private System.Windows.Forms.Button btnARequestDetails;
        private System.Windows.Forms.Button btnAReturnAll;
        private System.Windows.Forms.Button btnAApproveAll;
        private System.Windows.Forms.Label lblALastChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAFines;
    }
}
