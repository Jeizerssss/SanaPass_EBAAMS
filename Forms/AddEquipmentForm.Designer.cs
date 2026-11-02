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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblEquipmentDetails = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxEquipmentDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentName.Location = new System.Drawing.Point(64, 111);
            this.lblEquipmentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(38, 13);
            this.lblEquipmentName.TabIndex = 1;
            this.lblEquipmentName.Text = "Name:";
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipmentDesc
            // 
            this.lblEquipmentDesc.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDesc.Location = new System.Drawing.Point(14, 136);
            this.lblEquipmentDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentDesc.Name = "lblEquipmentDesc";
            this.lblEquipmentDesc.Size = new System.Drawing.Size(86, 37);
            this.lblEquipmentDesc.TabIndex = 2;
            this.lblEquipmentDesc.Text = "Equipment Description:";
            this.lblEquipmentDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(51, 221);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(54, 253);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(64, 285);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.ForeColor = System.Drawing.Color.White;
            this.lblCondition.Location = new System.Drawing.Point(50, 319);
            this.lblCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCondition.TabIndex = 8;
            this.lblCondition.Text = "Condition:";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipmentDetails
            // 
            this.lblEquipmentDetails.AutoSize = true;
            this.lblEquipmentDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblEquipmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentDetails.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentDetails.Location = new System.Drawing.Point(34, 24);
            this.lblEquipmentDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipmentDetails.Name = "lblEquipmentDetails";
            this.lblEquipmentDetails.Size = new System.Drawing.Size(262, 29);
            this.lblEquipmentDetails.TabIndex = 9;
            this.lblEquipmentDetails.Text = "EQUIPMENT DETAILS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 318);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(114, 283);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(77, 21);
            this.comboBoxStatus.TabIndex = 25;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(114, 250);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(172, 21);
            this.comboBoxLocation.TabIndex = 24;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(114, 219);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCategory.TabIndex = 23;
            // 
            // textBoxEquipmentDescription
            // 
            this.textBoxEquipmentDescription.Location = new System.Drawing.Point(114, 142);
            this.textBoxEquipmentDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEquipmentDescription.Multiline = true;
            this.textBoxEquipmentDescription.Name = "textBoxEquipmentDescription";
            this.textBoxEquipmentDescription.Size = new System.Drawing.Size(172, 62);
            this.textBoxEquipmentDescription.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 111);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 20);
            this.textBoxName.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(126, 390);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 41);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(326, 464);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxEquipmentDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblEquipmentDetails);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblEquipmentDesc);
            this.Controls.Add(this.lblEquipmentName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblEquipmentDetails;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxEquipmentDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnSave;
    }
}