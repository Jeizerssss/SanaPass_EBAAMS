namespace SanaPass_EBAAMS.Forms
{
    partial class SDashboard
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
            this.DashboardTop = new System.Windows.Forms.Panel();
            this.DashboardBottom = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTimeChecked = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DashboardTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardTop
            // 
            this.DashboardTop.BackColor = System.Drawing.Color.Maroon;
            this.DashboardTop.Controls.Add(this.btnRefresh);
            this.DashboardTop.Controls.Add(this.lblTimeChecked);
            this.DashboardTop.Controls.Add(this.label1);
            this.DashboardTop.Location = new System.Drawing.Point(0, 0);
            this.DashboardTop.Name = "DashboardTop";
            this.DashboardTop.Size = new System.Drawing.Size(788, 100);
            this.DashboardTop.TabIndex = 0;
            // 
            // DashboardBottom
            // 
            this.DashboardBottom.BackColor = System.Drawing.Color.Maroon;
            this.DashboardBottom.Location = new System.Drawing.Point(0, 480);
            this.DashboardBottom.Name = "DashboardBottom";
            this.DashboardBottom.Size = new System.Drawing.Size(788, 100);
            this.DashboardBottom.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.button4);
            this.pnlLeft.Controls.Add(this.button3);
            this.pnlLeft.Controls.Add(this.button2);
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.panel4);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Location = new System.Drawing.Point(3, 106);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(460, 368);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(469, 106);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(316, 368);
            this.pnlRight.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 69);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(28, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(28, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 69);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(28, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 69);
            this.panel4.TabIndex = 1;
            // 
            // lblTimeChecked
            // 
            this.lblTimeChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeChecked.Location = new System.Drawing.Point(489, 43);
            this.lblTimeChecked.Name = "lblTimeChecked";
            this.lblTimeChecked.Size = new System.Drawing.Size(175, 23);
            this.lblTimeChecked.TabIndex = 2;
            this.lblTimeChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(670, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.DashboardBottom);
            this.Controls.Add(this.DashboardTop);
            this.Name = "SDashboard";
            this.Size = new System.Drawing.Size(788, 580);
            this.DashboardTop.ResumeLayout(false);
            this.DashboardTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardTop;
        private System.Windows.Forms.Panel DashboardBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimeChecked;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
