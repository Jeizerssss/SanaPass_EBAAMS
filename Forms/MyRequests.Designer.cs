namespace SanaPass_EBAAMS.Forms
{
    partial class MyRequests
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
            this.pnlMyRequestsTop = new System.Windows.Forms.Panel();
            this.pnlMyRequestsBottom = new System.Windows.Forms.Panel();
            this.dgvMyRequests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMyRequestsDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMyRequestsTop.SuspendLayout();
            this.pnlMyRequestsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMyRequestsTop
            // 
            this.pnlMyRequestsTop.BackColor = System.Drawing.Color.Maroon;
            this.pnlMyRequestsTop.Controls.Add(this.comboBox1);
            this.pnlMyRequestsTop.Controls.Add(this.btnRefresh);
            this.pnlMyRequestsTop.Controls.Add(this.label1);
            this.pnlMyRequestsTop.Location = new System.Drawing.Point(3, 3);
            this.pnlMyRequestsTop.Name = "pnlMyRequestsTop";
            this.pnlMyRequestsTop.Size = new System.Drawing.Size(994, 80);
            this.pnlMyRequestsTop.TabIndex = 0;
            // 
            // pnlMyRequestsBottom
            // 
            this.pnlMyRequestsBottom.BackColor = System.Drawing.Color.Maroon;
            this.pnlMyRequestsBottom.Controls.Add(this.btnCancel);
            this.pnlMyRequestsBottom.Controls.Add(this.lblMyRequestsDescription);
            this.pnlMyRequestsBottom.Location = new System.Drawing.Point(3, 497);
            this.pnlMyRequestsBottom.Name = "pnlMyRequestsBottom";
            this.pnlMyRequestsBottom.Size = new System.Drawing.Size(994, 80);
            this.pnlMyRequestsBottom.TabIndex = 1;
            // 
            // dgvMyRequests
            // 
            this.dgvMyRequests.Location = new System.Drawing.Point(3, 89);
            this.dgvMyRequests.Name = "dgvMyRequests";
            this.dgvMyRequests.Size = new System.Drawing.Size(994, 402);
            this.dgvMyRequests.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY REQUESTS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(879, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Pending Approval",
            "Pending Release",
            "Pending Return"});
            this.comboBox1.Location = new System.Drawing.Point(694, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "All";
            // 
            // lblMyRequestsDescription
            // 
            this.lblMyRequestsDescription.AutoSize = true;
            this.lblMyRequestsDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblMyRequestsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyRequestsDescription.ForeColor = System.Drawing.Color.White;
            this.lblMyRequestsDescription.Location = new System.Drawing.Point(29, 29);
            this.lblMyRequestsDescription.Name = "lblMyRequestsDescription";
            this.lblMyRequestsDescription.Size = new System.Drawing.Size(509, 24);
            this.lblMyRequestsDescription.TabIndex = 0;
            this.lblMyRequestsDescription.Text = "Showing active items and history. Click a row to view details.";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(879, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MyRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMyRequests);
            this.Controls.Add(this.pnlMyRequestsBottom);
            this.Controls.Add(this.pnlMyRequestsTop);
            this.Name = "MyRequests";
            this.Size = new System.Drawing.Size(1000, 580);
            this.pnlMyRequestsTop.ResumeLayout(false);
            this.pnlMyRequestsTop.PerformLayout();
            this.pnlMyRequestsBottom.ResumeLayout(false);
            this.pnlMyRequestsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMyRequestsTop;
        private System.Windows.Forms.Panel pnlMyRequestsBottom;
        private System.Windows.Forms.DataGridView dgvMyRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMyRequestsDescription;
        private System.Windows.Forms.Button btnCancel;
    }
}
