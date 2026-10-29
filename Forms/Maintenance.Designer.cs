namespace SanaPass_EBAAMS.Forms
{
    partial class Maintenance
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
            this.pnlMaintenanceTop = new System.Windows.Forms.Panel();
            this.cmbAMaintenanceFilter = new System.Windows.Forms.ComboBox();
            this.btnARefreshMaintenance = new System.Windows.Forms.Button();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.txtBoxAMaintenanceSearch = new System.Windows.Forms.TextBox();
            this.pnlAEquipmentsBottom = new System.Windows.Forms.Panel();
            this.btnAddMaintenance = new System.Windows.Forms.Button();
            this.btnMaintenanceDetails = new System.Windows.Forms.Button();
            this.lblATotalMaintenance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.pnlMaintenanceTop.SuspendLayout();
            this.pnlAEquipmentsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMaintenanceTop
            // 
            this.pnlMaintenanceTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlMaintenanceTop.Controls.Add(this.cmbAMaintenanceFilter);
            this.pnlMaintenanceTop.Controls.Add(this.btnARefreshMaintenance);
            this.pnlMaintenanceTop.Controls.Add(this.lblMaintenance);
            this.pnlMaintenanceTop.Controls.Add(this.txtBoxAMaintenanceSearch);
            this.pnlMaintenanceTop.Location = new System.Drawing.Point(3, 3);
            this.pnlMaintenanceTop.Name = "pnlMaintenanceTop";
            this.pnlMaintenanceTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlMaintenanceTop.TabIndex = 4;
            // 
            // cmbAMaintenanceFilter
            // 
            this.cmbAMaintenanceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAMaintenanceFilter.FormattingEnabled = true;
            this.cmbAMaintenanceFilter.Location = new System.Drawing.Point(769, 35);
            this.cmbAMaintenanceFilter.Name = "cmbAMaintenanceFilter";
            this.cmbAMaintenanceFilter.Size = new System.Drawing.Size(146, 32);
            this.cmbAMaintenanceFilter.TabIndex = 3;
            this.cmbAMaintenanceFilter.Text = "All Status";
            // 
            // btnARefreshMaintenance
            // 
            this.btnARefreshMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshMaintenance.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshMaintenance.Name = "btnARefreshMaintenance";
            this.btnARefreshMaintenance.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshMaintenance.TabIndex = 2;
            this.btnARefreshMaintenance.Text = "Refresh";
            this.btnARefreshMaintenance.UseVisualStyleBackColor = true;
            this.btnARefreshMaintenance.Click += new System.EventHandler(this.btnARefreshEquipment_Click);
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblMaintenance.Location = new System.Drawing.Point(17, 19);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(385, 55);
            this.lblMaintenance.TabIndex = 0;
            this.lblMaintenance.Text = "MAINTENANCE";
            // 
            // txtBoxAMaintenanceSearch
            // 
            this.txtBoxAMaintenanceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAMaintenanceSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxAMaintenanceSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxAMaintenanceSearch.Name = "txtBoxAMaintenanceSearch";
            this.txtBoxAMaintenanceSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxAMaintenanceSearch.TabIndex = 1;
            this.txtBoxAMaintenanceSearch.Text = "Enter search";
            // 
            // pnlAEquipmentsBottom
            // 
            this.pnlAEquipmentsBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlAEquipmentsBottom.Controls.Add(this.btnAddMaintenance);
            this.pnlAEquipmentsBottom.Controls.Add(this.btnMaintenanceDetails);
            this.pnlAEquipmentsBottom.Controls.Add(this.lblATotalMaintenance);
            this.pnlAEquipmentsBottom.Controls.Add(this.label1);
            this.pnlAEquipmentsBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlAEquipmentsBottom.Name = "pnlAEquipmentsBottom";
            this.pnlAEquipmentsBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlAEquipmentsBottom.TabIndex = 6;
            // 
            // btnAddMaintenance
            // 
            this.btnAddMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaintenance.Location = new System.Drawing.Point(747, 25);
            this.btnAddMaintenance.Name = "btnAddMaintenance";
            this.btnAddMaintenance.Size = new System.Drawing.Size(145, 35);
            this.btnAddMaintenance.TabIndex = 5;
            this.btnAddMaintenance.Text = "Add Maintenance";
            this.btnAddMaintenance.UseVisualStyleBackColor = true;
            this.btnAddMaintenance.Click += new System.EventHandler(this.btnAddMaintenance_Click);
            // 
            // btnMaintenanceDetails
            // 
            this.btnMaintenanceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceDetails.Location = new System.Drawing.Point(898, 25);
            this.btnMaintenanceDetails.Name = "btnMaintenanceDetails";
            this.btnMaintenanceDetails.Size = new System.Drawing.Size(113, 35);
            this.btnMaintenanceDetails.TabIndex = 4;
            this.btnMaintenanceDetails.Text = "Details";
            this.btnMaintenanceDetails.UseVisualStyleBackColor = true;
            this.btnMaintenanceDetails.Click += new System.EventHandler(this.btnMaintenanceDetails_Click);
            // 
            // lblATotalMaintenance
            // 
            this.lblATotalMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotalMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblATotalMaintenance.Location = new System.Drawing.Point(170, 31);
            this.lblATotalMaintenance.Name = "lblATotalMaintenance";
            this.lblATotalMaintenance.Size = new System.Drawing.Size(163, 23);
            this.lblATotalMaintenance.TabIndex = 1;
            this.lblATotalMaintenance.Text = "0";
            this.lblATotalMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Maintenance:";
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Location = new System.Drawing.Point(3, 109);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.RowHeadersWidth = 51;
            this.dgvMaintenance.Size = new System.Drawing.Size(1045, 510);
            this.dgvMaintenance.TabIndex = 7;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.pnlAEquipmentsBottom);
            this.Controls.Add(this.pnlMaintenanceTop);
            this.Name = "Maintenance";
            this.Size = new System.Drawing.Size(1051, 714);
            this.pnlMaintenanceTop.ResumeLayout(false);
            this.pnlMaintenanceTop.PerformLayout();
            this.pnlAEquipmentsBottom.ResumeLayout(false);
            this.pnlAEquipmentsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMaintenanceTop;
        private System.Windows.Forms.ComboBox cmbAMaintenanceFilter;
        private System.Windows.Forms.Button btnARefreshMaintenance;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.TextBox txtBoxAMaintenanceSearch;
        private System.Windows.Forms.Panel pnlAEquipmentsBottom;
        private System.Windows.Forms.Button btnAddMaintenance;
        private System.Windows.Forms.Button btnMaintenanceDetails;
        private System.Windows.Forms.Label lblATotalMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaintenance;
    }
}
