namespace FinancialCrm
{
    partial class FrmBanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cmbBanks = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBankBalance1 = new System.Windows.Forms.Label();
            this.lblBankTitle1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBankBalance2 = new System.Windows.Forms.Label();
            this.lblBankTitle2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBankBalance3 = new System.Windows.Forms.Label();
            this.lblBankTitle3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFifth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFourth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.cmbBanks);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 349);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(11, 44);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(134, 29);
            this.txtBalance.TabIndex = 1;
            // 
            // cmbBanks
            // 
            this.cmbBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.Location = new System.Drawing.Point(11, 7);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(134, 31);
            this.cmbBanks.TabIndex = 0;
            this.cmbBanks.SelectedValueChanged += new System.EventHandler(this.cmbBanks_SelectedValueChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(11, 159);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(134, 34);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(11, 119);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(134, 34);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(11, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Balance";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 37);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.panel3.Controls.Add(this.lblBankBalance1);
            this.panel3.Controls.Add(this.lblBankTitle1);
            this.panel3.Location = new System.Drawing.Point(167, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblBankBalance1
            // 
            this.lblBankBalance1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankBalance1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankBalance1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankBalance1.Location = new System.Drawing.Point(0, 39);
            this.lblBankBalance1.Name = "lblBankBalance1";
            this.lblBankBalance1.Size = new System.Drawing.Size(200, 55);
            this.lblBankBalance1.TabIndex = 4;
            this.lblBankBalance1.Text = "0.00 ₺";
            this.lblBankBalance1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankTitle1
            // 
            this.lblBankTitle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankTitle1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankTitle1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankTitle1.Location = new System.Drawing.Point(0, 13);
            this.lblBankTitle1.Name = "lblBankTitle1";
            this.lblBankTitle1.Size = new System.Drawing.Size(200, 27);
            this.lblBankTitle1.TabIndex = 3;
            this.lblBankTitle1.Text = "Garanti BBVA";
            this.lblBankTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel4.Controls.Add(this.lblBankBalance2);
            this.panel4.Controls.Add(this.lblBankTitle2);
            this.panel4.Location = new System.Drawing.Point(373, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // lblBankBalance2
            // 
            this.lblBankBalance2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankBalance2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankBalance2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankBalance2.Location = new System.Drawing.Point(0, 39);
            this.lblBankBalance2.Name = "lblBankBalance2";
            this.lblBankBalance2.Size = new System.Drawing.Size(200, 55);
            this.lblBankBalance2.TabIndex = 6;
            this.lblBankBalance2.Text = "0.00 ₺";
            this.lblBankBalance2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankTitle2
            // 
            this.lblBankTitle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankTitle2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankTitle2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankTitle2.Location = new System.Drawing.Point(0, 13);
            this.lblBankTitle2.Name = "lblBankTitle2";
            this.lblBankTitle2.Size = new System.Drawing.Size(200, 18);
            this.lblBankTitle2.TabIndex = 5;
            this.lblBankTitle2.Text = "Is Bankasi";
            this.lblBankTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel5.Controls.Add(this.lblBankBalance3);
            this.panel5.Controls.Add(this.lblBankTitle3);
            this.panel5.Location = new System.Drawing.Point(579, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // lblBankBalance3
            // 
            this.lblBankBalance3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankBalance3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankBalance3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankBalance3.Location = new System.Drawing.Point(0, 39);
            this.lblBankBalance3.Name = "lblBankBalance3";
            this.lblBankBalance3.Size = new System.Drawing.Size(200, 55);
            this.lblBankBalance3.TabIndex = 8;
            this.lblBankBalance3.Text = "0.00 ₺";
            this.lblBankBalance3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankTitle3
            // 
            this.lblBankTitle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBankTitle3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankTitle3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBankTitle3.Location = new System.Drawing.Point(0, 13);
            this.lblBankTitle3.Name = "lblBankTitle3";
            this.lblBankTitle3.Size = new System.Drawing.Size(200, 18);
            this.lblBankTitle3.TabIndex = 7;
            this.lblBankTitle3.Text = "Ziraat Bankasi";
            this.lblBankTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblFifth);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblFourth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblThird);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(167, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last 5 Bank Transactions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(601, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblFifth
            // 
            this.lblFifth.AutoSize = true;
            this.lblFifth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFifth.Location = new System.Drawing.Point(6, 190);
            this.lblFifth.Name = "lblFifth";
            this.lblFifth.Size = new System.Drawing.Size(104, 20);
            this.lblFifth.TabIndex = 8;
            this.lblFifth.Text = "Fifth Transaction";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(601, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblFourth
            // 
            this.lblFourth.AutoSize = true;
            this.lblFourth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFourth.Location = new System.Drawing.Point(6, 150);
            this.lblFourth.Name = "lblFourth";
            this.lblFourth.Size = new System.Drawing.Size(117, 20);
            this.lblFourth.TabIndex = 6;
            this.lblFourth.Text = "Fourth Transaction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(601, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThird.Location = new System.Drawing.Point(6, 110);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(109, 20);
            this.lblThird.TabIndex = 4;
            this.lblThird.Text = "Third Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(601, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(6, 70);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(127, 20);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "Second Transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirst.Location = new System.Drawing.Point(6, 30);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(105, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Transaction";
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(780, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM";
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBankTitle1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBankBalance1;
        private System.Windows.Forms.Label lblBankBalance2;
        private System.Windows.Forms.Label lblBankTitle2;
        private System.Windows.Forms.Label lblBankBalance3;
        private System.Windows.Forms.Label lblBankTitle3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFifth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFourth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cmbBanks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

