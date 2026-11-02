namespace SanaPass_EBAAMS.Forms
{
    partial class Equipments
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
            this.pnlAEquipmentsTop = new System.Windows.Forms.Panel();
            this.cmbAEquipmentFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnARefreshEquipment = new System.Windows.Forms.Button();
            this.lblAEquipments = new System.Windows.Forms.Label();
            this.txtBoxAEquipmentSearch = new System.Windows.Forms.TextBox();
            this.pnlAEquipmentsBottom = new System.Windows.Forms.Panel();
            this.btnCatAndLoc = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnAEquipmentDetails = new System.Windows.Forms.Button();
            this.lblATotalEquipment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAEquipments = new System.Windows.Forms.DataGridView();
            this.pnlAEquipmentsTop.SuspendLayout();
            this.pnlAEquipmentsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAEquipments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAEquipmentsTop
            // 
            this.pnlAEquipmentsTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlAEquipmentsTop.Controls.Add(this.cmbAEquipmentFilterStatus);
            this.pnlAEquipmentsTop.Controls.Add(this.btnARefreshEquipment);
            this.pnlAEquipmentsTop.Controls.Add(this.lblAEquipments);
            this.pnlAEquipmentsTop.Controls.Add(this.txtBoxAEquipmentSearch);
            this.pnlAEquipmentsTop.Location = new System.Drawing.Point(2, 2);
            this.pnlAEquipmentsTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAEquipmentsTop.Name = "pnlAEquipmentsTop";
            this.pnlAEquipmentsTop.Size = new System.Drawing.Size(784, 81);
            this.pnlAEquipmentsTop.TabIndex = 3;
            // 
            // cmbAEquipmentFilterStatus
            // 
            this.cmbAEquipmentFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAEquipmentFilterStatus.FormattingEnabled = true;
            this.cmbAEquipmentFilterStatus.Location = new System.Drawing.Point(570, 28);
            this.cmbAEquipmentFilterStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAEquipmentFilterStatus.Name = "cmbAEquipmentFilterStatus";
            this.cmbAEquipmentFilterStatus.Size = new System.Drawing.Size(117, 32);
            this.cmbAEquipmentFilterStatus.TabIndex = 3;
            this.cmbAEquipmentFilterStatus.Text = "All Equipments";
            // 
            // btnARefreshEquipment
            // 
            this.btnARefreshEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshEquipment.Location = new System.Drawing.Point(691, 27);
            this.btnARefreshEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnARefreshEquipment.Name = "btnARefreshEquipment";
            this.btnARefreshEquipment.Size = new System.Drawing.Size(68, 29);
            this.btnARefreshEquipment.TabIndex = 2;
            this.btnARefreshEquipment.Text = "Refresh";
            this.btnARefreshEquipment.UseVisualStyleBackColor = true;
            this.btnARefreshEquipment.Click += new System.EventHandler(this.btnARefreshEquipment_Click);
            // 
            // lblAEquipments
            // 
            this.lblAEquipments.AutoSize = true;
            this.lblAEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAEquipments.ForeColor = System.Drawing.Color.White;
            this.lblAEquipments.Location = new System.Drawing.Point(13, 15);
            this.lblAEquipments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAEquipments.Name = "lblAEquipments";
            this.lblAEquipments.Size = new System.Drawing.Size(351, 55);
            this.lblAEquipments.TabIndex = 0;
            this.lblAEquipments.Text = "EQUIPMENTS";
            // 
            // txtBoxAEquipmentSearch
            // 
            this.txtBoxAEquipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAEquipmentSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxAEquipmentSearch.Location = new System.Drawing.Point(387, 28);
            this.txtBoxAEquipmentSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAEquipmentSearch.Name = "txtBoxAEquipmentSearch";
            this.txtBoxAEquipmentSearch.Size = new System.Drawing.Size(180, 29);
            this.txtBoxAEquipmentSearch.TabIndex = 1;
            this.txtBoxAEquipmentSearch.Text = "Enter search";
            // 
            // pnlAEquipmentsBottom
            // 
            this.pnlAEquipmentsBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlAEquipmentsBottom.Controls.Add(this.btnCatAndLoc);
            this.pnlAEquipmentsBottom.Controls.Add(this.btnAddEquipment);
            this.pnlAEquipmentsBottom.Controls.Add(this.btnAEquipmentDetails);
            this.pnlAEquipmentsBottom.Controls.Add(this.lblATotalEquipment);
            this.pnlAEquipmentsBottom.Controls.Add(this.label1);
            this.pnlAEquipmentsBottom.Location = new System.Drawing.Point(2, 508);
            this.pnlAEquipmentsBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAEquipmentsBottom.Name = "pnlAEquipmentsBottom";
            this.pnlAEquipmentsBottom.Size = new System.Drawing.Size(784, 70);
            this.pnlAEquipmentsBottom.TabIndex = 5;
            // 
            // btnCatAndLoc
            // 
            this.btnCatAndLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatAndLoc.Location = new System.Drawing.Point(387, 20);
            this.btnCatAndLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatAndLoc.Name = "btnCatAndLoc";
            this.btnCatAndLoc.Size = new System.Drawing.Size(179, 28);
            this.btnCatAndLoc.TabIndex = 6;
            this.btnCatAndLoc.Text = "Category and Location";
            this.btnCatAndLoc.UseVisualStyleBackColor = true;
            this.btnCatAndLoc.Click += new System.EventHandler(this.btnCatAndLoc_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(570, 20);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(99, 28);
            this.btnAddEquipment.TabIndex = 5;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnAEquipmentDetails
            // 
            this.btnAEquipmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAEquipmentDetails.Location = new System.Drawing.Point(674, 20);
            this.btnAEquipmentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnAEquipmentDetails.Name = "btnAEquipmentDetails";
            this.btnAEquipmentDetails.Size = new System.Drawing.Size(85, 28);
            this.btnAEquipmentDetails.TabIndex = 4;
            this.btnAEquipmentDetails.Text = "Details";
            this.btnAEquipmentDetails.UseVisualStyleBackColor = true;
            this.btnAEquipmentDetails.Click += new System.EventHandler(this.btnAEquipmentDetails_Click);
            // 
            // lblATotalEquipment
            // 
            this.lblATotalEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotalEquipment.ForeColor = System.Drawing.Color.White;
            this.lblATotalEquipment.Location = new System.Drawing.Point(161, 25);
            this.lblATotalEquipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblATotalEquipment.Name = "lblATotalEquipment";
            this.lblATotalEquipment.Size = new System.Drawing.Size(122, 19);
            this.lblATotalEquipment.TabIndex = 1;
            this.lblATotalEquipment.Text = "0";
            this.lblATotalEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Equipments:";
            // 
            // dgvAEquipments
            // 
            this.dgvAEquipments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAEquipments.Location = new System.Drawing.Point(2, 89);
            this.dgvAEquipments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAEquipments.Name = "dgvAEquipments";
            this.dgvAEquipments.RowHeadersWidth = 51;
            this.dgvAEquipments.Size = new System.Drawing.Size(784, 414);
            this.dgvAEquipments.TabIndex = 6;
            // 
            // Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAEquipments);
            this.Controls.Add(this.pnlAEquipmentsBottom);
            this.Controls.Add(this.pnlAEquipmentsTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipments";
            this.Size = new System.Drawing.Size(788, 580);
            this.pnlAEquipmentsTop.ResumeLayout(false);
            this.pnlAEquipmentsTop.PerformLayout();
            this.pnlAEquipmentsBottom.ResumeLayout(false);
            this.pnlAEquipmentsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAEquipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAEquipmentsTop;
        private System.Windows.Forms.ComboBox cmbAEquipmentFilterStatus;
        private System.Windows.Forms.Button btnARefreshEquipment;
        private System.Windows.Forms.Label lblAEquipments;
        private System.Windows.Forms.TextBox txtBoxAEquipmentSearch;
        private System.Windows.Forms.Panel pnlAEquipmentsBottom;
        private System.Windows.Forms.Button btnAEquipmentDetails;
        private System.Windows.Forms.Label lblATotalEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAEquipments;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnCatAndLoc;
    }
}
