namespace DOAN
{
    partial class fRegister
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
            panel7 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            panel5 = new Panel();
            txbRePassword = new TextBox();
            txbPassword = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txbUsername = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            cboxProfile = new ComboBox();
            cboxQuota = new ComboBox();
            cboxTableSpace = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label1 = new Label();
            txbHost = new TextBox();
            label2 = new Label();
            txbPort = new TextBox();
            label3 = new Label();
            txbSid = new TextBox();
            panel2 = new Panel();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(btnExit);
            panel7.Controls.Add(btnRegister);
            panel7.Location = new Point(502, 391);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(724, 116);
            panel7.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Cancel;
            btnExit.Font = new Font("Courier New", 12F);
            btnExit.ImeMode = ImeMode.NoControl;
            btnExit.Location = new Point(402, 21);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(232, 75);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Courier New", 12F);
            btnRegister.ImeMode = ImeMode.NoControl;
            btnRegister.Location = new Point(83, 21);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(232, 75);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbRePassword);
            panel5.Controls.Add(txbPassword);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txbUsername);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(502, 188);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(724, 190);
            panel5.TabIndex = 3;
            // 
            // txbRePassword
            // 
            txbRePassword.Font = new Font("Courier New", 15.75F);
            txbRePassword.Location = new Point(350, 127);
            txbRePassword.Margin = new Padding(4, 5, 4, 5);
            txbRePassword.Name = "txbRePassword";
            txbRePassword.Size = new Size(346, 37);
            txbRePassword.TabIndex = 9;
            txbRePassword.UseSystemPasswordChar = true;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Courier New", 15.75F);
            txbPassword.Location = new Point(350, 70);
            txbPassword.Margin = new Padding(4, 5, 4, 5);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(346, 37);
            txbPassword.TabIndex = 8;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(19, 127);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(302, 31);
            label6.TabIndex = 5;
            label6.Text = "Nhập lại mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(163, 76);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 31);
            label5.TabIndex = 7;
            label5.Text = "Mật khẩu:";
            // 
            // txbUsername
            // 
            txbUsername.Font = new Font("Courier New", 15.75F);
            txbUsername.Location = new Point(350, 15);
            txbUsername.Margin = new Padding(4, 5, 4, 5);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(346, 37);
            txbUsername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(83, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(238, 31);
            label4.TabIndex = 4;
            label4.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(cboxProfile);
            panel1.Controls.Add(cboxQuota);
            panel1.Controls.Add(cboxTableSpace);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(13, 374);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 170);
            panel1.TabIndex = 7;
            // 
            // cboxProfile
            // 
            cboxProfile.FormattingEnabled = true;
            cboxProfile.Location = new Point(210, 124);
            cboxProfile.Name = "cboxProfile";
            cboxProfile.Size = new Size(220, 28);
            cboxProfile.TabIndex = 8;
            // 
            // cboxQuota
            // 
            cboxQuota.FormattingEnabled = true;
            cboxQuota.Location = new Point(210, 71);
            cboxQuota.Name = "cboxQuota";
            cboxQuota.Size = new Size(220, 28);
            cboxQuota.TabIndex = 8;
            // 
            // cboxTableSpace
            // 
            cboxTableSpace.FormattingEnabled = true;
            cboxTableSpace.Location = new Point(210, 20);
            cboxTableSpace.Name = "cboxTableSpace";
            cboxTableSpace.Size = new Size(220, 28);
            cboxTableSpace.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(13, 121);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(142, 31);
            label9.TabIndex = 7;
            label9.Text = "Profile:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(13, 68);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 31);
            label8.TabIndex = 4;
            label8.Text = "Quota:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(13, 17);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 31);
            label7.TabIndex = 1;
            label7.Text = "TableSpace:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Location = new Point(136, 32);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 120);
            panel3.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(205, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(499, 53);
            label10.TabIndex = 0;
            label10.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(15, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 1;
            label1.Text = "Host:";
            // 
            // txbHost
            // 
            txbHost.Font = new Font("Courier New", 15.75F);
            txbHost.Location = new Point(117, 26);
            txbHost.Margin = new Padding(4, 5, 4, 5);
            txbHost.Name = "txbHost";
            txbHost.Size = new Size(223, 37);
            txbHost.TabIndex = 2;
            txbHost.Text = "localhost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(15, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 31);
            label2.TabIndex = 4;
            label2.Text = "Port:";
            // 
            // txbPort
            // 
            txbPort.Font = new Font("Courier New", 15.75F);
            txbPort.Location = new Point(117, 82);
            txbPort.Margin = new Padding(4, 5, 4, 5);
            txbPort.Name = "txbPort";
            txbPort.Size = new Size(223, 37);
            txbPort.TabIndex = 5;
            txbPort.Text = "1521";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(15, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 7;
            label3.Text = "SID:";
            // 
            // txbSid
            // 
            txbSid.Font = new Font("Courier New", 15.75F);
            txbSid.Location = new Point(117, 136);
            txbSid.Margin = new Padding(4, 5, 4, 5);
            txbSid.Name = "txbSid";
            txbSid.Size = new Size(223, 37);
            txbSid.TabIndex = 8;
            txbSid.Text = "orcl";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbSid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txbPort);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbHost);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(103, 162);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 202);
            panel2.TabIndex = 0;
            // 
            // fRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 621);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng kí";
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private TextBox txbRePassword;
        private TextBox txbPassword;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private Label label10;
        private ComboBox cboxTableSpace;
        private ComboBox cboxProfile;
        private ComboBox cboxQuota;
        private Label label1;
        private TextBox txbHost;
        private Label label2;
        private TextBox txbPort;
        private Label label3;
        private TextBox txbSid;
        private Panel panel2;
    }
}