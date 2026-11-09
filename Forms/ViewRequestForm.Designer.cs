namespace SanaPass_EBAAMS.Forms
{
    partial class ViewRequestForm
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
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.lblRequestDesc = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textRequestID = new System.Windows.Forms.Label();
            this.textRequestDate = new System.Windows.Forms.Label();
            this.textBorrowerName = new System.Windows.Forms.Label();
            this.textRequestDescription = new System.Windows.Forms.Label();
            this.textRequestStatus = new System.Windows.Forms.Label();
            this.lblRequestLocation = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.BackColor = System.Drawing.Color.Maroon;
            this.lblRequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDetails.ForeColor = System.Drawing.Color.White;
            this.lblRequestDetails.Location = new System.Drawing.Point(59, 35);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(312, 37);
            this.lblRequestDetails.TabIndex = 14;
            this.lblRequestDetails.Text = "REQUEST DETAILS";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(38, 369);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 25);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.ForeColor = System.Drawing.Color.White;
            this.lblEquipmentName.Location = new System.Drawing.Point(38, 217);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(120, 20);
            this.lblEquipmentName.TabIndex = 25;
            this.lblEquipmentName.Text = "Equipment:";
            this.lblEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.ForeColor = System.Drawing.Color.White;
            this.lblBorrowerName.Location = new System.Drawing.Point(38, 178);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(120, 24);
            this.lblBorrowerName.TabIndex = 24;
            this.lblBorrowerName.Text = "Borrower\'s Name:";
            this.lblBorrowerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequestDesc
            // 
            this.lblRequestDesc.ForeColor = System.Drawing.Color.White;
            this.lblRequestDesc.Location = new System.Drawing.Point(35, 248);
            this.lblRequestDesc.Name = "lblRequestDesc";
            this.lblRequestDesc.Size = new System.Drawing.Size(123, 45);
            this.lblRequestDesc.TabIndex = 23;
            this.lblRequestDesc.Text = "Request Description:";
            this.lblRequestDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.ForeColor = System.Drawing.Color.White;
            this.lblRequestDate.Location = new System.Drawing.Point(41, 143);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(117, 20);
            this.lblRequestDate.TabIndex = 22;
            this.lblRequestDate.Text = "Date:";
            this.lblRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRequestID
            // 
            this.lblRequestID.ForeColor = System.Drawing.Color.White;
            this.lblRequestID.Location = new System.Drawing.Point(38, 108);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(120, 22);
            this.lblRequestID.TabIndex = 21;
            this.lblRequestID.Text = "RequestID:";
            this.lblRequestID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.Black;
            this.btnApprove.Location = new System.Drawing.Point(156, 412);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(125, 42);
            this.btnApprove.TabIndex = 27;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(156, 460);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 42);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(156, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 42);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textRequestID
            // 
            this.textRequestID.Location = new System.Drawing.Point(164, 107);
            this.textRequestID.Name = "textRequestID";
            this.textRequestID.Size = new System.Drawing.Size(214, 23);
            this.textRequestID.TabIndex = 30;
            this.textRequestID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRequestDate
            // 
            this.textRequestDate.Location = new System.Drawing.Point(164, 140);
            this.textRequestDate.Name = "textRequestDate";
            this.textRequestDate.Size = new System.Drawing.Size(214, 23);
            this.textRequestDate.TabIndex = 31;
            this.textRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBorrowerName
            // 
            this.textBorrowerName.Location = new System.Drawing.Point(164, 179);
            this.textBorrowerName.Name = "textBorrowerName";
            this.textBorrowerName.Size = new System.Drawing.Size(214, 23);
            this.textBorrowerName.TabIndex = 32;
            this.textBorrowerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRequestDescription
            // 
            this.textRequestDescription.Location = new System.Drawing.Point(164, 248);
            this.textRequestDescription.Name = "textRequestDescription";
            this.textRequestDescription.Size = new System.Drawing.Size(214, 77);
            this.textRequestDescription.TabIndex = 33;
            this.textRequestDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textRequestStatus
            // 
            this.textRequestStatus.Location = new System.Drawing.Point(164, 367);
            this.textRequestStatus.Name = "textRequestStatus";
            this.textRequestStatus.Size = new System.Drawing.Size(214, 28);
            this.textRequestStatus.TabIndex = 34;
            this.textRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequestLocation
            // 
            this.lblRequestLocation.ForeColor = System.Drawing.Color.White;
            this.lblRequestLocation.Location = new System.Drawing.Point(38, 336);
            this.lblRequestLocation.Name = "lblRequestLocation";
            this.lblRequestLocation.Size = new System.Drawing.Size(120, 24);
            this.lblRequestLocation.TabIndex = 35;
            this.lblRequestLocation.Text = "Location:";
            this.lblRequestLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(164, 334);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(214, 28);
            this.textLocation.TabIndex = 36;
            this.textLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(434, 571);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.lblRequestLocation);
            this.Controls.Add(this.textRequestStatus);
            this.Controls.Add(this.textRequestDescription);
            this.Controls.Add(this.textBorrowerName);
            this.Controls.Add(this.textRequestDate);
            this.Controls.Add(this.textRequestID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblBorrowerName);
            this.Controls.Add(this.lblRequestDesc);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblRequestDetails);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ViewRequestForm";
            this.Text = "ViewRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Label lblRequestDesc;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label textRequestID;
        private System.Windows.Forms.Label textRequestDate;
        private System.Windows.Forms.Label textBorrowerName;
        private System.Windows.Forms.Label textRequestDescription;
        private System.Windows.Forms.Label textRequestStatus;
        private System.Windows.Forms.Label lblRequestLocation;
        private System.Windows.Forms.Label textLocation;
    }
}