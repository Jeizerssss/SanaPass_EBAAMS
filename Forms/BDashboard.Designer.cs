namespace SanaPass_EBAAMS.Forms
{
    partial class BDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBorrowerAccount = new System.Windows.Forms.Label();
            this.panelActiveBorrow = new System.Windows.Forms.Panel();
            this.panelFines = new System.Windows.Forms.Panel();
            this.panelPendingRequests = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblActiveBorrows2 = new System.Windows.Forms.Label();
            this.lblActiveBorrows1 = new System.Windows.Forms.Label();
            this.lblActiveBorrowsCount = new System.Windows.Forms.Label();
            this.lblPendingRequestsCount = new System.Windows.Forms.Label();
            this.lblPendingRequests1 = new System.Windows.Forms.Label();
            this.lblPendingRequests2 = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.lblDgvMyRecentRequests = new System.Windows.Forms.Label();
            this.dgvMyRecentRequests = new System.Windows.Forms.DataGridView();
            this.btnBorrowNewItem = new System.Windows.Forms.Button();
            this.btnViewAllRequests = new System.Windows.Forms.Button();
            this.panelActiveBorrow.SuspendLayout();
            this.panelFines.SuspendLayout();
            this.panelPendingRequests.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(31, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(342, 47);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hello, Name!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBorrowerAccount
            // 
            this.lblBorrowerAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerAccount.ForeColor = System.Drawing.Color.White;
            this.lblBorrowerAccount.Location = new System.Drawing.Point(31, 69);
            this.lblBorrowerAccount.Name = "lblBorrowerAccount";
            this.lblBorrowerAccount.Size = new System.Drawing.Size(259, 19);
            this.lblBorrowerAccount.TabIndex = 1;
            this.lblBorrowerAccount.Text = "Borrower Account";
            this.lblBorrowerAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelActiveBorrow
            // 
            this.panelActiveBorrow.Controls.Add(this.lblActiveBorrowsCount);
            this.panelActiveBorrow.Controls.Add(this.lblActiveBorrows1);
            this.panelActiveBorrow.Controls.Add(this.lblActiveBorrows2);
            this.panelActiveBorrow.Location = new System.Drawing.Point(34, 103);
            this.panelActiveBorrow.Name = "panelActiveBorrow";
            this.panelActiveBorrow.Size = new System.Drawing.Size(333, 148);
            this.panelActiveBorrow.TabIndex = 2;
            // 
            // panelFines
            // 
            this.panelFines.Controls.Add(this.lblBalanceAmount);
            this.panelFines.Controls.Add(this.lblBalance1);
            this.panelFines.Controls.Add(this.lblBalance2);
            this.panelFines.Location = new System.Drawing.Point(34, 400);
            this.panelFines.Name = "panelFines";
            this.panelFines.Size = new System.Drawing.Size(333, 145);
            this.panelFines.TabIndex = 3;
            // 
            // panelPendingRequests
            // 
            this.panelPendingRequests.Controls.Add(this.lblPendingRequestsCount);
            this.panelPendingRequests.Controls.Add(this.lblPendingRequests1);
            this.panelPendingRequests.Controls.Add(this.lblPendingRequests2);
            this.panelPendingRequests.Location = new System.Drawing.Point(34, 257);
            this.panelPendingRequests.Name = "panelPendingRequests";
            this.panelPendingRequests.Size = new System.Drawing.Size(333, 137);
            this.panelPendingRequests.TabIndex = 3;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dgvMyRecentRequests);
            this.panelContainer.Controls.Add(this.lblDgvMyRecentRequests);
            this.panelContainer.Location = new System.Drawing.Point(373, 103);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(592, 442);
            this.panelContainer.TabIndex = 4;
            // 
            // lblActiveBorrows2
            // 
            this.lblActiveBorrows2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBorrows2.ForeColor = System.Drawing.Color.White;
            this.lblActiveBorrows2.Location = new System.Drawing.Point(92, 109);
            this.lblActiveBorrows2.Name = "lblActiveBorrows2";
            this.lblActiveBorrows2.Size = new System.Drawing.Size(144, 23);
            this.lblActiveBorrows2.TabIndex = 0;
            this.lblActiveBorrows2.Text = "active borrows.";
            this.lblActiveBorrows2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveBorrows1
            // 
            this.lblActiveBorrows1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBorrows1.ForeColor = System.Drawing.Color.White;
            this.lblActiveBorrows1.Location = new System.Drawing.Point(92, 18);
            this.lblActiveBorrows1.Name = "lblActiveBorrows1";
            this.lblActiveBorrows1.Size = new System.Drawing.Size(144, 23);
            this.lblActiveBorrows1.TabIndex = 1;
            this.lblActiveBorrows1.Text = "You currently have";
            this.lblActiveBorrows1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveBorrowsCount
            // 
            this.lblActiveBorrowsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBorrowsCount.ForeColor = System.Drawing.Color.White;
            this.lblActiveBorrowsCount.Location = new System.Drawing.Point(92, 41);
            this.lblActiveBorrowsCount.Name = "lblActiveBorrowsCount";
            this.lblActiveBorrowsCount.Size = new System.Drawing.Size(144, 68);
            this.lblActiveBorrowsCount.TabIndex = 2;
            this.lblActiveBorrowsCount.Text = "0";
            this.lblActiveBorrowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingRequestsCount
            // 
            this.lblPendingRequestsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequestsCount.ForeColor = System.Drawing.Color.White;
            this.lblPendingRequestsCount.Location = new System.Drawing.Point(94, 34);
            this.lblPendingRequestsCount.Name = "lblPendingRequestsCount";
            this.lblPendingRequestsCount.Size = new System.Drawing.Size(144, 68);
            this.lblPendingRequestsCount.TabIndex = 5;
            this.lblPendingRequestsCount.Text = "0";
            this.lblPendingRequestsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingRequests1
            // 
            this.lblPendingRequests1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequests1.ForeColor = System.Drawing.Color.White;
            this.lblPendingRequests1.Location = new System.Drawing.Point(94, 11);
            this.lblPendingRequests1.Name = "lblPendingRequests1";
            this.lblPendingRequests1.Size = new System.Drawing.Size(144, 23);
            this.lblPendingRequests1.TabIndex = 4;
            this.lblPendingRequests1.Text = "You currently have";
            this.lblPendingRequests1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingRequests2
            // 
            this.lblPendingRequests2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequests2.ForeColor = System.Drawing.Color.White;
            this.lblPendingRequests2.Location = new System.Drawing.Point(94, 102);
            this.lblPendingRequests2.Name = "lblPendingRequests2";
            this.lblPendingRequests2.Size = new System.Drawing.Size(144, 23);
            this.lblPendingRequests2.TabIndex = 3;
            this.lblPendingRequests2.Text = "pending requests.";
            this.lblPendingRequests2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.White;
            this.lblBalanceAmount.Location = new System.Drawing.Point(94, 38);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(144, 68);
            this.lblBalanceAmount.TabIndex = 5;
            this.lblBalanceAmount.Text = "0";
            this.lblBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance1
            // 
            this.lblBalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance1.ForeColor = System.Drawing.Color.White;
            this.lblBalance1.Location = new System.Drawing.Point(94, 15);
            this.lblBalance1.Name = "lblBalance1";
            this.lblBalance1.Size = new System.Drawing.Size(144, 23);
            this.lblBalance1.TabIndex = 4;
            this.lblBalance1.Text = "You currently have";
            this.lblBalance1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance2
            // 
            this.lblBalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance2.ForeColor = System.Drawing.Color.White;
            this.lblBalance2.Location = new System.Drawing.Point(74, 106);
            this.lblBalance2.Name = "lblBalance2";
            this.lblBalance2.Size = new System.Drawing.Size(185, 23);
            this.lblBalance2.TabIndex = 3;
            this.lblBalance2.Text = "total outstanding fines.";
            this.lblBalance2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDgvMyRecentRequests
            // 
            this.lblDgvMyRecentRequests.BackColor = System.Drawing.Color.Transparent;
            this.lblDgvMyRecentRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgvMyRecentRequests.ForeColor = System.Drawing.Color.White;
            this.lblDgvMyRecentRequests.Location = new System.Drawing.Point(0, 0);
            this.lblDgvMyRecentRequests.Name = "lblDgvMyRecentRequests";
            this.lblDgvMyRecentRequests.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDgvMyRecentRequests.Size = new System.Drawing.Size(592, 60);
            this.lblDgvMyRecentRequests.TabIndex = 0;
            this.lblDgvMyRecentRequests.Text = "Recent Request Status and Lifecycle Tracking";
            this.lblDgvMyRecentRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMyRecentRequests
            // 
            this.dgvMyRecentRequests.Location = new System.Drawing.Point(3, 63);
            this.dgvMyRecentRequests.Name = "dgvMyRecentRequests";
            this.dgvMyRecentRequests.Size = new System.Drawing.Size(586, 376);
            this.dgvMyRecentRequests.TabIndex = 1;
            // 
            // btnBorrowNewItem
            // 
            this.btnBorrowNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowNewItem.Location = new System.Drawing.Point(782, 31);
            this.btnBorrowNewItem.Name = "btnBorrowNewItem";
            this.btnBorrowNewItem.Size = new System.Drawing.Size(180, 46);
            this.btnBorrowNewItem.TabIndex = 5;
            this.btnBorrowNewItem.Text = "Borrow New Item";
            this.btnBorrowNewItem.UseVisualStyleBackColor = true;
            this.btnBorrowNewItem.Click += new System.EventHandler(this.btnBorrowNewItem_Click);
            // 
            // btnViewAllRequests
            // 
            this.btnViewAllRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllRequests.Location = new System.Drawing.Point(596, 31);
            this.btnViewAllRequests.Name = "btnViewAllRequests";
            this.btnViewAllRequests.Size = new System.Drawing.Size(180, 46);
            this.btnViewAllRequests.TabIndex = 6;
            this.btnViewAllRequests.Text = "View All Requests";
            this.btnViewAllRequests.UseVisualStyleBackColor = true;
            this.btnViewAllRequests.Click += new System.EventHandler(this.btnViewAllRequests_Click);
            // 
            // BDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnViewAllRequests);
            this.Controls.Add(this.btnBorrowNewItem);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelPendingRequests);
            this.Controls.Add(this.panelFines);
            this.Controls.Add(this.panelActiveBorrow);
            this.Controls.Add(this.lblBorrowerAccount);
            this.Controls.Add(this.lblWelcome);
            this.Name = "BDashboard";
            this.Size = new System.Drawing.Size(1000, 580);
            this.panelActiveBorrow.ResumeLayout(false);
            this.panelFines.ResumeLayout(false);
            this.panelPendingRequests.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBorrowerAccount;
        private System.Windows.Forms.Panel panelActiveBorrow;
        private System.Windows.Forms.Panel panelFines;
        private System.Windows.Forms.Panel panelPendingRequests;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblActiveBorrows2;
        private System.Windows.Forms.Label lblActiveBorrowsCount;
        private System.Windows.Forms.Label lblActiveBorrows1;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label lblBalance1;
        private System.Windows.Forms.Label lblBalance2;
        private System.Windows.Forms.Label lblPendingRequestsCount;
        private System.Windows.Forms.Label lblPendingRequests1;
        private System.Windows.Forms.Label lblPendingRequests2;
        private System.Windows.Forms.DataGridView dgvMyRecentRequests;
        private System.Windows.Forms.Label lblDgvMyRecentRequests;
        private System.Windows.Forms.Button btnBorrowNewItem;
        private System.Windows.Forms.Button btnViewAllRequests;
    }
}
