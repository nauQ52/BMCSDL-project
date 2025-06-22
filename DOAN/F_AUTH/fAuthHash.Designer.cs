namespace DOAN.F_AUTH
{
    partial class fAuthHash
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
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnLogin = new Button();
            panel5 = new Panel();
            btnHash = new Button();
            txbPassword = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            txbHash = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 108);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 0;
            label1.Text = "Xác thực Hash";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogin);
            panel3.Location = new Point(34, 306);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 106);
            panel3.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Courier New", 12F);
            btnLogin.ImeMode = ImeMode.NoControl;
            btnLogin.Location = new Point(308, 14);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(232, 75);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHash);
            panel5.Controls.Add(txbPassword);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(34, 145);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(847, 60);
            panel5.TabIndex = 0;
            // 
            // btnHash
            // 
            btnHash.Font = new Font("Courier New", 12F);
            btnHash.ImeMode = ImeMode.NoControl;
            btnHash.Location = new Point(627, 9);
            btnHash.Margin = new Padding(4, 5, 4, 5);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(198, 40);
            btnHash.TabIndex = 5;
            btnHash.Text = "HASH";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Courier New", 15.75F);
            txbPassword.Location = new Point(216, 10);
            txbPassword.Margin = new Padding(4, 5, 4, 5);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(386, 37);
            txbPassword.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(15, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 31);
            label6.TabIndex = 4;
            label6.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbHash);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 215);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 72);
            panel2.TabIndex = 6;
            // 
            // txbHash
            // 
            txbHash.Font = new Font("Courier New", 15.75F);
            txbHash.Location = new Point(216, 13);
            txbHash.Margin = new Padding(4, 5, 4, 5);
            txbHash.Name = "txbHash";
            txbHash.Size = new Size(609, 37);
            txbHash.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(15, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 4;
            label2.Text = "H(Pa):";
            // 
            // fAuthHash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 517);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "fAuthHash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAuthHash";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btnLogin;
        private Panel panel5;
        private TextBox txbPassword;
        private Label label6;
        private Button btnHash;
        private Panel panel2;
        private TextBox txbHash;
        private Label label2;
    }
}