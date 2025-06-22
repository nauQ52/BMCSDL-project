namespace DOAN
{
    partial class fAuthSym
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
            btnLogin = new Button();
            panel5 = new Panel();
            btnGetNonce = new Button();
            txbNonceBorn = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            numbKey = new NumericUpDown();
            txtNonce = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            txtNonceCipher = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numbKey).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 108);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 0;
            label1.Text = "Xác thực Đối xứng";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Courier New", 12F);
            btnLogin.ImeMode = ImeMode.NoControl;
            btnLogin.Location = new Point(598, 17);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(212, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnGetNonce);
            panel5.Controls.Add(txbNonceBorn);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(35, 145);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(847, 60);
            panel5.TabIndex = 12;
            // 
            // btnGetNonce
            // 
            btnGetNonce.Font = new Font("Courier New", 12F);
            btnGetNonce.ImeMode = ImeMode.NoControl;
            btnGetNonce.Location = new Point(660, 10);
            btnGetNonce.Margin = new Padding(4, 5, 4, 5);
            btnGetNonce.Name = "btnGetNonce";
            btnGetNonce.Size = new Size(162, 38);
            btnGetNonce.TabIndex = 5;
            btnGetNonce.Text = "Get";
            btnGetNonce.UseVisualStyleBackColor = true;
            // 
            // txbNonceBorn
            // 
            txbNonceBorn.Font = new Font("Courier New", 15.75F);
            txbNonceBorn.Location = new Point(165, 10);
            txbNonceBorn.Margin = new Padding(4, 5, 4, 5);
            txbNonceBorn.Name = "txbNonceBorn";
            txbNonceBorn.PasswordChar = '*';
            txbNonceBorn.Size = new Size(467, 37);
            txbNonceBorn.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(15, 13);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(142, 31);
            label6.TabIndex = 4;
            label6.Text = "Nonce B:";
            // 
            // panel4
            // 
            panel4.Controls.Add(numbKey);
            panel4.Controls.Add(txtNonce);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(35, 215);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 60);
            panel4.TabIndex = 13;
            // 
            // numbKey
            // 
            numbKey.Location = new Point(660, 17);
            numbKey.Name = "numbKey";
            numbKey.Size = new Size(150, 27);
            numbKey.TabIndex = 5;
            // 
            // txtNonce
            // 
            txtNonce.Font = new Font("Courier New", 15.75F);
            txtNonce.Location = new Point(133, 10);
            txtNonce.Margin = new Padding(4, 5, 4, 5);
            txtNonce.Name = "txtNonce";
            txtNonce.PasswordChar = '*';
            txtNonce.Size = new Size(434, 37);
            txtNonce.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(575, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 4;
            label4.Text = "Key:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(15, 13);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 4;
            label5.Text = "Nonce:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNonceCipher);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(35, 279);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(847, 60);
            panel6.TabIndex = 13;
            // 
            // txtNonceCipher
            // 
            txtNonceCipher.Font = new Font("Courier New", 15.75F);
            txtNonceCipher.Location = new Point(229, 10);
            txtNonceCipher.Margin = new Padding(4, 5, 4, 5);
            txtNonceCipher.Name = "txtNonceCipher";
            txtNonceCipher.PasswordChar = '*';
            txtNonceCipher.Size = new Size(592, 37);
            txtNonceCipher.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(15, 13);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(222, 31);
            label7.TabIndex = 4;
            label7.Text = "Cipher Nonce:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(35, 349);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 92);
            panel2.TabIndex = 14;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 12F);
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(297, 17);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(212, 55);
            button2.TabIndex = 4;
            button2.Text = "Encrypt";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 12F);
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(15, 17);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(212, 55);
            button1.TabIndex = 4;
            button1.Text = "Decrypt";
            button1.UseVisualStyleBackColor = true;
            // 
            // fAuthSym
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 488);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "fAuthSym";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAuthSym";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numbKey).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Panel panel5;
        private TextBox txbNonceBorn;
        private Label label6;
        private Panel panel4;
        private NumericUpDown numbKey;
        private TextBox txtNonce;
        private Label label4;
        private Label label5;
        private Button btnGetNonce;
        private Panel panel6;
        private TextBox txtNonceCipher;
        private Label label7;
        private Panel panel2;
        private Button button2;
        private Button button1;
    }
}