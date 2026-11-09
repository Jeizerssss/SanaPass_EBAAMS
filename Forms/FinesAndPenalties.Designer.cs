namespace SanaPass_EBAAMS.Forms
{
    partial class FinesAndPenalties
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
            this.pnlFinesAndPenaltiesTop = new System.Windows.Forms.Panel();
            this.cmbFinesAnPenaltiesFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblFinesAndPenalties = new System.Windows.Forms.Label();
            this.pnlFinesAndPenaltiesBottom = new System.Windows.Forms.Panel();
            this.lblFinesAndPenaltiesDescription = new System.Windows.Forms.Label();
            this.dgvFinesAndPenalties = new System.Windows.Forms.DataGridView();
            this.pnlFinesAndPenaltiesTop.SuspendLayout();
            this.pnlFinesAndPenaltiesBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMyRequestsTop
            // 
            this.pnlFinesAndPenaltiesTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlFinesAndPenaltiesTop.Controls.Add(this.cmbFinesAnPenaltiesFilter);
            this.pnlFinesAndPenaltiesTop.Controls.Add(this.btnRefresh);
            this.pnlFinesAndPenaltiesTop.Controls.Add(this.lblFinesAndPenalties);
            this.pnlFinesAndPenaltiesTop.Location = new System.Drawing.Point(3, 3);
            this.pnlFinesAndPenaltiesTop.Name = "pnlMyRequestsTop";
            this.pnlFinesAndPenaltiesTop.Size = new System.Drawing.Size(994, 80);
            this.pnlFinesAndPenaltiesTop.TabIndex = 1;
            // 
            // cmbFinesAnPenaltiesFilter
            // 
            this.cmbFinesAnPenaltiesFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinesAnPenaltiesFilter.FormattingEnabled = true;
            this.cmbFinesAnPenaltiesFilter.Items.AddRange(new object[] {
            "All",
            "Pending Approval",
            "Pending Release",
            "Pending Return"});
            this.cmbFinesAnPenaltiesFilter.Location = new System.Drawing.Point(694, 26);
            this.cmbFinesAnPenaltiesFilter.Name = "cmbFinesAnPenaltiesFilter";
            this.cmbFinesAnPenaltiesFilter.Size = new System.Drawing.Size(179, 28);
            this.cmbFinesAnPenaltiesFilter.TabIndex = 2;
            this.cmbFinesAnPenaltiesFilter.Text = "All";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(879, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblFinesAndPenalties
            // 
            this.lblFinesAndPenalties.AutoSize = true;
            this.lblFinesAndPenalties.BackColor = System.Drawing.Color.Transparent;
            this.lblFinesAndPenalties.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinesAndPenalties.ForeColor = System.Drawing.Color.White;
            this.lblFinesAndPenalties.Location = new System.Drawing.Point(26, 21);
            this.lblFinesAndPenalties.Name = "lblFinesAndPenalties";
            this.lblFinesAndPenalties.Size = new System.Drawing.Size(393, 37);
            this.lblFinesAndPenalties.TabIndex = 0;
            this.lblFinesAndPenalties.Text = "FINES AND PENALTIES";
            // 
            // pnlMyRequestsBottom
            // 
            this.pnlFinesAndPenaltiesBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlFinesAndPenaltiesBottom.Controls.Add(this.lblFinesAndPenaltiesDescription);
            this.pnlFinesAndPenaltiesBottom.Location = new System.Drawing.Point(3, 497);
            this.pnlFinesAndPenaltiesBottom.Name = "pnlMyRequestsBottom";
            this.pnlFinesAndPenaltiesBottom.Size = new System.Drawing.Size(994, 80);
            this.pnlFinesAndPenaltiesBottom.TabIndex = 2;
            // 
            // lblFinesAndPenaltiesDescription
            // 
            this.lblFinesAndPenaltiesDescription.AutoSize = true;
            this.lblFinesAndPenaltiesDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFinesAndPenaltiesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinesAndPenaltiesDescription.ForeColor = System.Drawing.Color.White;
            this.lblFinesAndPenaltiesDescription.Location = new System.Drawing.Point(29, 29);
            this.lblFinesAndPenaltiesDescription.Name = "lblFinesAndPenaltiesDescription";
            this.lblFinesAndPenaltiesDescription.Size = new System.Drawing.Size(509, 24);
            this.lblFinesAndPenaltiesDescription.TabIndex = 0;
            this.lblFinesAndPenaltiesDescription.Text = "Showing active items and history. Click a row to view details.";
            // 
            // dgvFinesAndPenalties
            // 
            this.dgvFinesAndPenalties.Location = new System.Drawing.Point(3, 89);
            this.dgvFinesAndPenalties.Name = "dgvFinesAndPenalties";
            this.dgvFinesAndPenalties.Size = new System.Drawing.Size(994, 402);
            this.dgvFinesAndPenalties.TabIndex = 3;
            // 
            // FinesAndPenalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFinesAndPenalties);
            this.Controls.Add(this.pnlFinesAndPenaltiesBottom);
            this.Controls.Add(this.pnlFinesAndPenaltiesTop);
            this.Name = "FinesAndPenalties";
            this.Size = new System.Drawing.Size(1000, 580);
            this.pnlFinesAndPenaltiesTop.ResumeLayout(false);
            this.pnlFinesAndPenaltiesTop.PerformLayout();
            this.pnlFinesAndPenaltiesBottom.ResumeLayout(false);
            this.pnlFinesAndPenaltiesBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFinesAndPenaltiesTop;
        private System.Windows.Forms.ComboBox cmbFinesAnPenaltiesFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblFinesAndPenalties;
        private System.Windows.Forms.Panel pnlFinesAndPenaltiesBottom;
        private System.Windows.Forms.Label lblFinesAndPenaltiesDescription;
        private System.Windows.Forms.DataGridView dgvFinesAndPenalties;
    }
}
