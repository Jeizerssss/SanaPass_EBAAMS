namespace SanaPass_EBAAMS.Forms
{
    partial class Users
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
            this.pnlUsersTop = new System.Windows.Forms.Panel();
            this.cmbUsersFilter = new System.Windows.Forms.ComboBox();
            this.btnARefreshUsers = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.txtBoxUsersSearch = new System.Windows.Forms.TextBox();
            this.pnlAEquipmentsBottom = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUsersDetails = new System.Windows.Forms.Button();
            this.lblATotalUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlUsersTop.SuspendLayout();
            this.pnlAEquipmentsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsersTop
            // 
            this.pnlUsersTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlUsersTop.Controls.Add(this.cmbUsersFilter);
            this.pnlUsersTop.Controls.Add(this.btnARefreshUsers);
            this.pnlUsersTop.Controls.Add(this.lblUsers);
            this.pnlUsersTop.Controls.Add(this.txtBoxUsersSearch);
            this.pnlUsersTop.Location = new System.Drawing.Point(3, 3);
            this.pnlUsersTop.Name = "pnlUsersTop";
            this.pnlUsersTop.Size = new System.Drawing.Size(1045, 100);
            this.pnlUsersTop.TabIndex = 5;
            // 
            // cmbUsersFilter
            // 
            this.cmbUsersFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsersFilter.FormattingEnabled = true;
            this.cmbUsersFilter.Location = new System.Drawing.Point(769, 35);
            this.cmbUsersFilter.Name = "cmbUsersFilter";
            this.cmbUsersFilter.Size = new System.Drawing.Size(146, 32);
            this.cmbUsersFilter.TabIndex = 3;
            this.cmbUsersFilter.Text = "All Status";
            // 
            // btnARefreshUsers
            // 
            this.btnARefreshUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARefreshUsers.Location = new System.Drawing.Point(921, 33);
            this.btnARefreshUsers.Name = "btnARefreshUsers";
            this.btnARefreshUsers.Size = new System.Drawing.Size(90, 36);
            this.btnARefreshUsers.TabIndex = 2;
            this.btnARefreshUsers.Text = "Refresh";
            this.btnARefreshUsers.UseVisualStyleBackColor = true;
            this.btnARefreshUsers.Click += new System.EventHandler(this.btnARefreshEquipment_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(17, 19);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(195, 55);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "USERS";
            // 
            // txtBoxUsersSearch
            // 
            this.txtBoxUsersSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsersSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxUsersSearch.Location = new System.Drawing.Point(525, 35);
            this.txtBoxUsersSearch.Name = "txtBoxUsersSearch";
            this.txtBoxUsersSearch.Size = new System.Drawing.Size(238, 29);
            this.txtBoxUsersSearch.TabIndex = 1;
            this.txtBoxUsersSearch.Text = "Enter search";
            // 
            // pnlAEquipmentsBottom
            // 
            this.pnlAEquipmentsBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlAEquipmentsBottom.Controls.Add(this.btnAddUser);
            this.pnlAEquipmentsBottom.Controls.Add(this.btnUsersDetails);
            this.pnlAEquipmentsBottom.Controls.Add(this.lblATotalUsers);
            this.pnlAEquipmentsBottom.Controls.Add(this.label1);
            this.pnlAEquipmentsBottom.Location = new System.Drawing.Point(3, 625);
            this.pnlAEquipmentsBottom.Name = "pnlAEquipmentsBottom";
            this.pnlAEquipmentsBottom.Size = new System.Drawing.Size(1045, 86);
            this.pnlAEquipmentsBottom.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(769, 25);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(123, 35);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUsersDetails
            // 
            this.btnUsersDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersDetails.Location = new System.Drawing.Point(898, 25);
            this.btnUsersDetails.Name = "btnUsersDetails";
            this.btnUsersDetails.Size = new System.Drawing.Size(113, 35);
            this.btnUsersDetails.TabIndex = 4;
            this.btnUsersDetails.Text = "Details";
            this.btnUsersDetails.UseVisualStyleBackColor = true;
            this.btnUsersDetails.Click += new System.EventHandler(this.btnUsersDetails_Click);
            // 
            // lblATotalUsers
            // 
            this.lblATotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATotalUsers.ForeColor = System.Drawing.Color.White;
            this.lblATotalUsers.Location = new System.Drawing.Point(127, 31);
            this.lblATotalUsers.Name = "lblATotalUsers";
            this.lblATotalUsers.Size = new System.Drawing.Size(163, 23);
            this.lblATotalUsers.TabIndex = 1;
            this.lblATotalUsers.Text = "0";
            this.lblATotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Users:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(3, 109);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(1045, 510);
            this.dgvUsers.TabIndex = 8;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlAEquipmentsBottom);
            this.Controls.Add(this.pnlUsersTop);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1051, 714);
            this.pnlUsersTop.ResumeLayout(false);
            this.pnlUsersTop.PerformLayout();
            this.pnlAEquipmentsBottom.ResumeLayout(false);
            this.pnlAEquipmentsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsersTop;
        private System.Windows.Forms.ComboBox cmbUsersFilter;
        private System.Windows.Forms.Button btnARefreshUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtBoxUsersSearch;
        private System.Windows.Forms.Panel pnlAEquipmentsBottom;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUsersDetails;
        private System.Windows.Forms.Label lblATotalUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}
