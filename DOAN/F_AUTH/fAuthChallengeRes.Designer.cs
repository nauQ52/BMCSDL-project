namespace DOAN
{
    partial class fAuthChallengeRes
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
            panel2 = new Panel();
            btnEncrypt = new Button();
            txbAuthChallengeRes = new TextBox();
            label3 = new Label();
            txbNonce = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnSend = new Button();
            label4 = new Label();
            txbPassword = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 35);
            label1.Name = "label1";
            label1.Size = new Size(597, 37);
            label1.TabIndex = 0;
            label1.Text = "Xác thực Challenge - Response";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnEncrypt);
            panel2.Controls.Add(txbAuthChallengeRes);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txbNonce);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 176);
            panel2.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(513, 66);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(309, 53);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Mã hóa Hash h(PA, N)";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txbAuthChallengeRes
            // 
            txbAuthChallengeRes.Location = new Point(301, 130);
            txbAuthChallengeRes.Name = "txbAuthChallengeRes";
            txbAuthChallengeRes.Size = new Size(521, 30);
            txbAuthChallengeRes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 133);
            label3.Name = "label3";
            label3.Size = new Size(262, 22);
            label3.TabIndex = 2;
            label3.Text = "Mã hóa Hash h(PA, N):";
            // 
            // txbNonce
            // 
            txbNonce.Location = new Point(301, 78);
            txbNonce.Name = "txbNonce";
            txbNonce.ReadOnly = true;
            txbNonce.Size = new Size(185, 30);
            txbNonce.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 81);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 0;
            label2.Text = "Số Nonce: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSend);
            panel3.Location = new Point(13, 310);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 76);
            panel3.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(596, 14);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(226, 59);
            btnSend.TabIndex = 0;
            btnSend.Text = "Gửi mã xác thực";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 25);
            label4.Name = "label4";
            label4.Size = new Size(118, 22);
            label4.TabIndex = 5;
            label4.Text = "Mật khẩu:";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(301, 22);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(521, 30);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // fAuthChallengeRes
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 403);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fAuthChallengeRes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác thực";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txbNonce;
        private Label label2;
        private Button btnEncrypt;
        private TextBox txbAuthChallengeRes;
        private Label label3;
        private Button btnSend;
        private TextBox txbPassword;
        private Label label4;
    }
}