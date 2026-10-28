namespace SanaPass_EBAAMS
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblRegister = new System.Windows.Forms.Label();
            this.lLblLogin = new System.Windows.Forms.LinkLabel();
            this.pBoxLogin = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lblRegister.Location = new System.Drawing.Point(488, 383);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(120, 13);
            this.lblRegister.TabIndex = 19;
            this.lblRegister.Text = "already have account?";
            // 
            // lLblLogin
            // 
            this.lLblLogin.AutoSize = true;
            this.lLblLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.lLblLogin.Location = new System.Drawing.Point(614, 383);
            this.lLblLogin.Name = "lLblLogin";
            this.lLblLogin.Size = new System.Drawing.Size(68, 13);
            this.lLblLogin.TabIndex = 18;
            this.lLblLogin.TabStop = true;
            this.lLblLogin.Text = "Log in here.";
            this.lLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblLogin_LinkClicked);
            // 
            // pBoxLogin
            // 
            this.pBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogin.Image")));
            this.pBoxLogin.Location = new System.Drawing.Point(-4, -7);
            this.pBoxLogin.Name = "pBoxLogin";
            this.pBoxLogin.Size = new System.Drawing.Size(394, 539);
            this.pBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogin.TabIndex = 17;
            this.pBoxLogin.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubtitle.Location = new System.Drawing.Point(493, 83);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(177, 30);
            this.lblSubtitle.TabIndex = 16;
            this.lblSubtitle.Text = "Equipment Borrowing and Asset\r\n Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(505, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 45);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "EBAAMS";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(546, 411);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 39);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMName.Location = new System.Drawing.Point(456, 220);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(251, 25);
            this.txtMName.TabIndex = 13;
            this.txtMName.UseSystemPasswordChar = true;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblMName.Location = new System.Drawing.Point(452, 196);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(107, 21);
            this.lblMName.TabIndex = 12;
            this.lblMName.Text = "Middle Name:";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(456, 165);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(251, 26);
            this.txtFName.TabIndex = 11;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblFName.Location = new System.Drawing.Point(452, 141);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(89, 21);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name:";
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBoxLName.Location = new System.Drawing.Point(456, 276);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(251, 25);
            this.txtBoxLName.TabIndex = 21;
            this.txtBoxLName.UseSystemPasswordChar = true;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblLName.Location = new System.Drawing.Point(452, 252);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(87, 21);
            this.lblLName.TabIndex = 20;
            this.lblLName.Text = "Last Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(456, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 25);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblEmail.Location = new System.Drawing.Point(452, 307);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lLblLogin);
            this.Controls.Add(this.pBoxLogin);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.LinkLabel lLblLogin;
        private System.Windows.Forms.PictureBox pBoxLogin;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}