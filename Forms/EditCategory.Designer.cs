namespace SanaPass_EBAAMS.Forms
{
    partial class EditCategory
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
            this.lblCategoryDetails = new System.Windows.Forms.Label();
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCategoryDetails
            // 
            this.lblCategoryDetails.AutoSize = true;
            this.lblCategoryDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblCategoryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryDetails.ForeColor = System.Drawing.Color.White;
            this.lblCategoryDetails.Location = new System.Drawing.Point(47, 35);
            this.lblCategoryDetails.Name = "lblCategoryDetails";
            this.lblCategoryDetails.Size = new System.Drawing.Size(339, 37);
            this.lblCategoryDetails.TabIndex = 14;
            this.lblCategoryDetails.Text = "CATEGORY DETAILS";
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.ForeColor = System.Drawing.Color.White;
            this.lblCategoryDesc.Location = new System.Drawing.Point(11, 125);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(115, 45);
            this.lblCategoryDesc.TabIndex = 30;
            this.lblCategoryDesc.Text = "Category Description:";
            this.lblCategoryDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(79, 94);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(47, 16);
            this.lblCategoryName.TabIndex = 29;
            this.lblCategoryName.Text = "Name:";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(163, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(132, 91);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(243, 22);
            this.textBoxCategoryName.TabIndex = 35;
            // 
            // textBoxCategoryDesc
            // 
            this.textBoxCategoryDesc.Location = new System.Drawing.Point(132, 125);
            this.textBoxCategoryDesc.Multiline = true;
            this.textBoxCategoryDesc.Name = "textBoxCategoryDesc";
            this.textBoxCategoryDesc.Size = new System.Drawing.Size(243, 45);
            this.textBoxCategoryDesc.TabIndex = 36;
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.textBoxCategoryDesc);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCategoryDesc);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryDetails);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryDetails;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryDesc;
    }
}