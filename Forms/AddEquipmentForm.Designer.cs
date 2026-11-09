namespace SanaPass_EBAAMS.Forms
{
    partial class AddEquipmentForm
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
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblEquipmentDesc = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxEquipmentDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEquipmentDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentName.Location = new System.Drawing.Point(85, 102);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(47, 16);
            this.lblEquipmentName.TabIndex = 1;
            this.lblEquipmentName.Text = "Name:";
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipmentDesc
            // 
            this.lblEquipmentDesc.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDesc.Location = new System.Drawing.Point(19, 132);
            this.lblEquipmentDesc.Name = "lblEquipmentDesc";
            this.lblEquipmentDesc.Size = new System.Drawing.Size(115, 46);
            this.lblEquipmentDesc.TabIndex = 2;
            this.lblEquipmentDesc.Text = "Equipment Description:";
            this.lblEquipmentDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(68, 237);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(72, 276);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 16);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(152, 273);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(228, 24);
            this.comboBoxLocation.TabIndex = 24;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(152, 235);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(228, 24);
            this.comboBoxCategory.TabIndex = 23;
            // 
            // textBoxEquipmentDescription
            // 
            this.textBoxEquipmentDescription.Location = new System.Drawing.Point(152, 140);
            this.textBoxEquipmentDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEquipmentDescription.Multiline = true;
            this.textBoxEquipmentDescription.Name = "textBoxEquipmentDescription";
            this.textBoxEquipmentDescription.Size = new System.Drawing.Size(228, 75);
            this.textBoxEquipmentDescription.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 102);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 22);
            this.textBoxName.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(168, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEquipmentDetails
            // 
            this.lblEquipmentDetails.AutoSize = true;
            this.lblEquipmentDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblEquipmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentDetails.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDetails.Location = new System.Drawing.Point(43, 37);
            this.lblEquipmentDetails.Name = "lblEquipmentDetails";
            this.lblEquipmentDetails.Size = new System.Drawing.Size(348, 37);
            this.lblEquipmentDetails.TabIndex = 28;
            this.lblEquipmentDetails.Text = "EQUIPMENT DETAILS";
            // 
            // AddEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(435, 571);
            this.Controls.Add(this.lblEquipmentDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxEquipmentDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblEquipmentDesc);
            this.Controls.Add(this.lblEquipmentName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEquipmentForm";
            this.Text = "EquipmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblEquipmentDesc;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxEquipmentDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEquipmentDetails;
    }
}