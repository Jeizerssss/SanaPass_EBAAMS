namespace SanaPass_EBAAMS.Forms
{
    partial class EditLocation
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
            this.textBoxLocationDesc = new System.Windows.Forms.TextBox();
            this.textBoxLocationName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLocationDesc = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblLocationDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLocationDesc
            // 
            this.textBoxLocationDesc.Location = new System.Drawing.Point(135, 121);
            this.textBoxLocationDesc.Multiline = true;
            this.textBoxLocationDesc.Name = "textBoxLocationDesc";
            this.textBoxLocationDesc.Size = new System.Drawing.Size(243, 45);
            this.textBoxLocationDesc.TabIndex = 42;
            // 
            // textBoxLocationName
            // 
            this.textBoxLocationName.Location = new System.Drawing.Point(135, 87);
            this.textBoxLocationName.Name = "textBoxLocationName";
            this.textBoxLocationName.Size = new System.Drawing.Size(243, 22);
            this.textBoxLocationName.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(166, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblLocationDesc
            // 
            this.lblLocationDesc.ForeColor = System.Drawing.Color.White;
            this.lblLocationDesc.Location = new System.Drawing.Point(14, 121);
            this.lblLocationDesc.Name = "lblLocationDesc";
            this.lblLocationDesc.Size = new System.Drawing.Size(115, 45);
            this.lblLocationDesc.TabIndex = 39;
            this.lblLocationDesc.Text = "Location Description:";
            this.lblLocationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(82, 90);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(47, 16);
            this.lblCategoryName.TabIndex = 38;
            this.lblCategoryName.Text = "Name:";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLocationDetails
            // 
            this.lblLocationDetails.AutoSize = true;
            this.lblLocationDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblLocationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDetails.ForeColor = System.Drawing.Color.White;
            this.lblLocationDetails.Location = new System.Drawing.Point(54, 34);
            this.lblLocationDetails.Name = "lblLocationDetails";
            this.lblLocationDetails.Size = new System.Drawing.Size(324, 37);
            this.lblLocationDetails.TabIndex = 37;
            this.lblLocationDetails.Text = "LOCATION DETAILS";
            // 
            // EditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.textBoxLocationDesc);
            this.Controls.Add(this.textBoxLocationName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLocationDesc);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblLocationDetails);
            this.Name = "EditLocation";
            this.Text = "EditLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLocationDesc;
        private System.Windows.Forms.TextBox textBoxLocationName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLocationDesc;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblLocationDetails;
    }
}