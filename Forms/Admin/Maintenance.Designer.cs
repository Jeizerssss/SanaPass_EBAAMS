namespace SanaPass_EBAAMS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.colMaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 70);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Maintenance";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "search equipment";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(476, 20);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 33);
            this.cmbStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(411, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(656, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(848, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+ Add Maintenance";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.AllowUserToResizeRows = false;
            this.dgvMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaintenance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaintenanceID,
            this.colDate,
            this.colEquipment,
            this.colDescription,
            this.colStatus});
            this.dgvMaintenance.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvMaintenance.Location = new System.Drawing.Point(20, 150);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.RowHeadersWidth = 62;
            this.dgvMaintenance.RowTemplate.Height = 28;
            this.dgvMaintenance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(1140, 450);
            this.dgvMaintenance.TabIndex = 2;
            // 
            // colMaintenanceID
            // 
            this.colMaintenanceID.HeaderText = "Maintenance ID";
            this.colMaintenanceID.MinimumWidth = 8;
            this.colMaintenanceID.Name = "colMaintenanceID";
            this.colMaintenanceID.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colEquipment
            // 
            this.colEquipment.HeaderText = "Equipment";
            this.colEquipment.MinimumWidth = 8;
            this.colEquipment.Name = "colEquipment";
            this.colEquipment.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 8;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Logs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaintenanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}