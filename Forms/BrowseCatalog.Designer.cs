namespace SanaPass_EBAAMS.Forms
{
    partial class BrowseCatalog
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
            this.panelBCTop = new System.Windows.Forms.Panel();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEquipmentSearch = new System.Windows.Forms.TextBox();
            this.panelBCBottom = new System.Windows.Forms.Panel();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.btnRequestItem = new System.Windows.Forms.Button();
            this.panelBCRight = new System.Windows.Forms.Panel();
            this.lblEStatus = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblEDesc = new System.Windows.Forms.Label();
            this.lblEName = new System.Windows.Forms.Label();
            this.lblEquipmentStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEquipmentDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEquipmentDetails = new System.Windows.Forms.Label();
            this.dgvEquipmentList = new System.Windows.Forms.DataGridView();
            this.panelBCTop.SuspendLayout();
            this.panelBCBottom.SuspendLayout();
            this.panelBCRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBCTop
            // 
            this.panelBCTop.BackColor = System.Drawing.Color.Maroon;
            this.panelBCTop.Controls.Add(this.cmbBoxCategory);
            this.panelBCTop.Controls.Add(this.label2);
            this.panelBCTop.Controls.Add(this.txtBoxEquipmentSearch);
            this.panelBCTop.Location = new System.Drawing.Point(0, 0);
            this.panelBCTop.Name = "panelBCTop";
            this.panelBCTop.Size = new System.Drawing.Size(1000, 85);
            this.panelBCTop.TabIndex = 0;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(822, 29);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(155, 28);
            this.cmbBoxCategory.TabIndex = 2;
            this.cmbBoxCategory.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "BROWSE CATALOG";
            // 
            // txtBoxEquipmentSearch
            // 
            this.txtBoxEquipmentSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEquipmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEquipmentSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxEquipmentSearch.Location = new System.Drawing.Point(587, 31);
            this.txtBoxEquipmentSearch.Name = "txtBoxEquipmentSearch";
            this.txtBoxEquipmentSearch.Size = new System.Drawing.Size(213, 26);
            this.txtBoxEquipmentSearch.TabIndex = 0;
            this.txtBoxEquipmentSearch.Text = "Enter name of item";
            this.txtBoxEquipmentSearch.TextChanged += new System.EventHandler(this.txtBoxEquipmentSearch_TextChanged);
            // 
            // panelBCBottom
            // 
            this.panelBCBottom.BackColor = System.Drawing.Color.Maroon;
            this.panelBCBottom.Controls.Add(this.lblPurpose);
            this.panelBCBottom.Controls.Add(this.txtBoxPurpose);
            this.panelBCBottom.Controls.Add(this.btnRequestItem);
            this.panelBCBottom.Location = new System.Drawing.Point(0, 495);
            this.panelBCBottom.Name = "panelBCBottom";
            this.panelBCBottom.Size = new System.Drawing.Size(1000, 85);
            this.panelBCBottom.TabIndex = 1;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.ForeColor = System.Drawing.Color.White;
            this.lblPurpose.Location = new System.Drawing.Point(31, 15);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(238, 20);
            this.lblPurpose.TabIndex = 2;
            this.lblPurpose.Text = "Purpose / Reason for Borrowing:";
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPurpose.Location = new System.Drawing.Point(24, 38);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(742, 26);
            this.txtBoxPurpose.TabIndex = 1;
            // 
            // btnRequestItem
            // 
            this.btnRequestItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestItem.Location = new System.Drawing.Point(855, 25);
            this.btnRequestItem.Name = "btnRequestItem";
            this.btnRequestItem.Size = new System.Drawing.Size(122, 39);
            this.btnRequestItem.TabIndex = 0;
            this.btnRequestItem.Text = "Request Item";
            this.btnRequestItem.UseVisualStyleBackColor = true;
            // 
            // panelBCRight
            // 
            this.panelBCRight.BackColor = System.Drawing.Color.Maroon;
            this.panelBCRight.Controls.Add(this.lblEStatus);
            this.panelBCRight.Controls.Add(this.lblCategoryID);
            this.panelBCRight.Controls.Add(this.lblEDesc);
            this.panelBCRight.Controls.Add(this.lblEName);
            this.panelBCRight.Controls.Add(this.lblEquipmentStatus);
            this.panelBCRight.Controls.Add(this.lblCategory);
            this.panelBCRight.Controls.Add(this.lblEquipmentDescription);
            this.panelBCRight.Controls.Add(this.lblName);
            this.panelBCRight.Controls.Add(this.lblEquipmentDetails);
            this.panelBCRight.Location = new System.Drawing.Point(772, 91);
            this.panelBCRight.Name = "panelBCRight";
            this.panelBCRight.Size = new System.Drawing.Size(225, 398);
            this.panelBCRight.TabIndex = 2;
            // 
            // lblEStatus
            // 
            this.lblEStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEStatus.ForeColor = System.Drawing.Color.White;
            this.lblEStatus.Location = new System.Drawing.Point(3, 305);
            this.lblEStatus.Name = "lblEStatus";
            this.lblEStatus.Size = new System.Drawing.Size(215, 23);
            this.lblEStatus.TabIndex = 8;
            this.lblEStatus.Text = "NONE";
            this.lblEStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryID.ForeColor = System.Drawing.Color.White;
            this.lblCategoryID.Location = new System.Drawing.Point(3, 253);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(215, 23);
            this.lblCategoryID.TabIndex = 7;
            this.lblCategoryID.Text = "NONE";
            this.lblCategoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEDesc
            // 
            this.lblEDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDesc.ForeColor = System.Drawing.Color.White;
            this.lblEDesc.Location = new System.Drawing.Point(3, 156);
            this.lblEDesc.Name = "lblEDesc";
            this.lblEDesc.Size = new System.Drawing.Size(215, 65);
            this.lblEDesc.TabIndex = 6;
            this.lblEDesc.Text = "NONE";
            this.lblEDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEName
            // 
            this.lblEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEName.ForeColor = System.Drawing.Color.White;
            this.lblEName.Location = new System.Drawing.Point(7, 117);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(215, 23);
            this.lblEName.TabIndex = 5;
            this.lblEName.Text = "NONE";
            this.lblEName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipmentStatus
            // 
            this.lblEquipmentStatus.AutoSize = true;
            this.lblEquipmentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentStatus.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentStatus.Location = new System.Drawing.Point(80, 328);
            this.lblEquipmentStatus.Name = "lblEquipmentStatus";
            this.lblEquipmentStatus.Size = new System.Drawing.Size(65, 16);
            this.lblEquipmentStatus.TabIndex = 4;
            this.lblEquipmentStatus.Text = "STATUS:";
            this.lblEquipmentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(72, 276);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 16);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "CATEGORY:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipmentDescription
            // 
            this.lblEquipmentDescription.AutoSize = true;
            this.lblEquipmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentDescription.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDescription.Location = new System.Drawing.Point(64, 221);
            this.lblEquipmentDescription.Name = "lblEquipmentDescription";
            this.lblEquipmentDescription.Size = new System.Drawing.Size(101, 16);
            this.lblEquipmentDescription.TabIndex = 2;
            this.lblEquipmentDescription.Text = "DESCRIPTION:";
            this.lblEquipmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(90, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipmentDetails
            // 
            this.lblEquipmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentDetails.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDetails.Location = new System.Drawing.Point(3, 10);
            this.lblEquipmentDetails.Name = "lblEquipmentDetails";
            this.lblEquipmentDetails.Size = new System.Drawing.Size(219, 65);
            this.lblEquipmentDetails.TabIndex = 0;
            this.lblEquipmentDetails.Text = "EQUIPMENT DETAILS";
            this.lblEquipmentDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEquipmentList
            // 
            this.dgvEquipmentList.Location = new System.Drawing.Point(3, 91);
            this.dgvEquipmentList.Name = "dgvEquipmentList";
            this.dgvEquipmentList.Size = new System.Drawing.Size(763, 398);
            this.dgvEquipmentList.TabIndex = 3;
            // 
            // BrowseCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgvEquipmentList);
            this.Controls.Add(this.panelBCRight);
            this.Controls.Add(this.panelBCBottom);
            this.Controls.Add(this.panelBCTop);
            this.Name = "BrowseCatalog";
            this.Size = new System.Drawing.Size(1000, 580);
            this.panelBCTop.ResumeLayout(false);
            this.panelBCTop.PerformLayout();
            this.panelBCBottom.ResumeLayout(false);
            this.panelBCBottom.PerformLayout();
            this.panelBCRight.ResumeLayout(false);
            this.panelBCRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBCTop;
        private System.Windows.Forms.Panel panelBCBottom;
        private System.Windows.Forms.Panel panelBCRight;
        private System.Windows.Forms.DataGridView dgvEquipmentList;
        private System.Windows.Forms.Button btnRequestItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEquipmentSearch;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.TextBox txtBoxPurpose;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label lblEquipmentDetails;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblEquipmentDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblEquipmentStatus;
        private System.Windows.Forms.Label lblEStatus;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblEDesc;
    }
}
