namespace DOAN.F_AUTH
{
    partial class fAuthSimple
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
            btnLogin = new Button();
            panel3 = new Panel();
            label6 = new Label();
            txbPassword = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Courier New", 12F);
            btnLogin.ImeMode = ImeMode.NoControl;
            btnLogin.Location = new Point(307, 16);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 75);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(13, 261);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 106);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(18, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 31);
            label6.TabIndex = 4;
            label6.Text = "Mật Khẩu:";
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Courier New", 15.75F);
            txbPassword.Location = new Point(247, 29);
            txbPassword.Margin = new Padding(4, 5, 4, 5);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(489, 37);
            txbPassword.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbPassword);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(13, 145);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(847, 106);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(317, 37);
            label1.TabIndex = 0;
            label1.Text = "Xác thực Simple";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 108);
            panel1.TabIndex = 6;
            // 
            // fAuthSimple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 423);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "fAuthSimple";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAuthSimple";
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Panel panel3;
        private Label label6;
        private TextBox txbPassword;
        private Panel panel5;
        private Label label1;
        private Panel panel1;
    }
}