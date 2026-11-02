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
            this.btnSettleFine = new System.Windows.Forms.Button();
            this.btnARequestDetails = new System.Windows.Forms.Button();
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
            this.pnlAFinesTop.Location = new System.Drawing.Point(2, 2);
            this.pnlAFinesTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAFinesTop.Name = "pnlAFinesTop";
            this.pnlAFinesTop.Size = new System.Drawing.Size(784, 81);
            this.pnlAFinesTop.TabIndex = 3;
            // 
            // cmbAFilterStatus
            // 
            this.cmbAFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAFilterStatus.FormattingEnabled = true;
            this.cmbAFilterStatus.Location = new System.Drawing.Point(577, 28);
            this.cmbAFilterStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAFilterStatus.Name = "cmbAFilterStatus";
            this.cmbAFilterStatus.Size = new System.Drawing.Size(110, 32);
            this.cmbAFilterStatus.TabIndex = 3;
            this.cmbAFilterStatus.Text = "All";
            // 
            // btnARefreshFines
            // 
            this.btnARefreshFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshFines.Location = new System.Drawing.Point(691, 27);
            this.btnARefreshFines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnARefreshFines.Name = "btnARefreshFines";
            this.btnARefreshFines.Size = new System.Drawing.Size(68, 29);
            this.btnARefreshFines.TabIndex = 2;
            this.btnARefreshFines.Text = "Refresh";
            this.btnARefreshFines.UseVisualStyleBackColor = true;
            // 
            // lblAFines
            // 
            this.lblAFines.AutoSize = true;
            this.lblAFines.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFines.ForeColor = System.Drawing.Color.White;
            this.lblAFines.Location = new System.Drawing.Point(15, 18);
            this.lblAFines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAFines.Name = "lblAFines";
            this.lblAFines.Size = new System.Drawing.Size(170, 55);
            this.lblAFines.TabIndex = 0;
            this.lblAFines.Text = "FINES";
            // 
            // txtBoxAFinesSearch
            // 
            this.txtBoxAFinesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAFinesSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxAFinesSearch.Location = new System.Drawing.Point(394, 28);
            this.txtBoxAFinesSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxAFinesSearch.Name = "txtBoxAFinesSearch";
            this.txtBoxAFinesSearch.Size = new System.Drawing.Size(180, 29);
            this.txtBoxAFinesSearch.TabIndex = 1;
            this.txtBoxAFinesSearch.Text = "Enter search";
            // 
            // pnlAFinesBottom
            // 
            this.pnlAFinesBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlAFinesBottom.Controls.Add(this.btnSettleFine);
            this.pnlAFinesBottom.Controls.Add(this.btnARequestDetails);
            this.pnlAFinesBottom.Controls.Add(this.lblALastChecked);
            this.pnlAFinesBottom.Controls.Add(this.label1);
            this.pnlAFinesBottom.Location = new System.Drawing.Point(2, 508);
            this.pnlAFinesBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAFinesBottom.Name = "pnlAFinesBottom";
            this.pnlAFinesBottom.Size = new System.Drawing.Size(784, 70);
            this.pnlAFinesBottom.TabIndex = 5;
            // 
            // btnSettleFine
            // 
            this.btnSettleFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettleFine.Location = new System.Drawing.Point(577, 20);
            this.btnSettleFine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettleFine.Name = "btnSettleFine";
            this.btnSettleFine.Size = new System.Drawing.Size(85, 28);
            this.btnSettleFine.TabIndex = 5;
            this.btnSettleFine.Text = "Settle Fine";
            this.btnSettleFine.UseVisualStyleBackColor = true;
            // 
            // btnARequestDetails
            // 
            this.btnARequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARequestDetails.Location = new System.Drawing.Point(674, 20);
            this.btnARequestDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnARequestDetails.Name = "btnARequestDetails";
            this.btnARequestDetails.Size = new System.Drawing.Size(85, 28);
            this.btnARequestDetails.TabIndex = 4;
            this.btnARequestDetails.Text = "Details";
            this.btnARequestDetails.UseVisualStyleBackColor = true;
            // 
            // lblALastChecked
            // 
            this.lblALastChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALastChecked.ForeColor = System.Drawing.Color.White;
            this.lblALastChecked.Location = new System.Drawing.Point(132, 29);
            this.lblALastChecked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblALastChecked.Name = "lblALastChecked";
            this.lblALastChecked.Size = new System.Drawing.Size(122, 19);
            this.lblALastChecked.TabIndex = 1;
            this.lblALastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last checked:";
            // 
            // dgvAFines
            // 
            this.dgvAFines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFines.Location = new System.Drawing.Point(2, 89);
            this.dgvAFines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAFines.Name = "dgvAFines";
            this.dgvAFines.RowHeadersWidth = 51;
            this.dgvAFines.Size = new System.Drawing.Size(784, 414);
            this.dgvAFines.TabIndex = 6;
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAFines);
            this.Controls.Add(this.pnlAFinesBottom);
            this.Controls.Add(this.pnlAFinesTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Fines";
            this.Size = new System.Drawing.Size(788, 580);
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
        private System.Windows.Forms.Label lblALastChecked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAFines;
        private System.Windows.Forms.Button btnSettleFine;
    }
}
