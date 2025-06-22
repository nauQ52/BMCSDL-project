namespace DOAN
{
    partial class fAuthentication
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
            button1 = new Button();
            btnAuthPublicKey = new Button();
            btnAuthSym = new Button();
            btnHash = new Button();
            btnSimple = new Button();
            btnAuthChallengeRes = new Button();
            panel3 = new Panel();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 542);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 227);
            label1.Name = "label1";
            label1.Size = new Size(442, 22);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng chọn phương thức xác thực: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnAuthPublicKey);
            panel2.Controls.Add(btnAuthSym);
            panel2.Controls.Add(btnHash);
            panel2.Controls.Add(btnSimple);
            panel2.Controls.Add(btnAuthChallengeRes);
            panel2.Location = new Point(494, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 542);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(103, 453);
            button1.Name = "button1";
            button1.Size = new Size(547, 41);
            button1.TabIndex = 2;
            button1.Text = "Xác thực Khuôn mặt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAuthFace_Click;
            // 
            // btnAuthPublicKey
            // 
            btnAuthPublicKey.Location = new Point(103, 372);
            btnAuthPublicKey.Name = "btnAuthPublicKey";
            btnAuthPublicKey.Size = new Size(547, 41);
            btnAuthPublicKey.TabIndex = 2;
            btnAuthPublicKey.Text = "Xác thực Khóa công khai";
            btnAuthPublicKey.UseVisualStyleBackColor = true;
            btnAuthPublicKey.Click += btnAuthPublicKey_Click;
            // 
            // btnAuthSym
            // 
            btnAuthSym.Location = new Point(103, 285);
            btnAuthSym.Name = "btnAuthSym";
            btnAuthSym.Size = new Size(547, 41);
            btnAuthSym.TabIndex = 1;
            btnAuthSym.Text = "Xác thực Khóa đối xứng";
            btnAuthSym.UseVisualStyleBackColor = true;
            btnAuthSym.Click += btnAuthSym_Click;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(103, 118);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(547, 41);
            btnHash.TabIndex = 0;
            btnHash.Text = "Xác thực Hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnAuthHash_Click;
            // 
            // btnSimple
            // 
            btnSimple.Location = new Point(103, 31);
            btnSimple.Name = "btnSimple";
            btnSimple.Size = new Size(547, 41);
            btnSimple.TabIndex = 0;
            btnSimple.Text = "Xác thực Đơn giản";
            btnSimple.UseVisualStyleBackColor = true;
            btnSimple.Click += btnSimple_Click;
            // 
            // btnAuthChallengeRes
            // 
            btnAuthChallengeRes.Location = new Point(103, 199);
            btnAuthChallengeRes.Name = "btnAuthChallengeRes";
            btnAuthChallengeRes.Size = new Size(547, 41);
            btnAuthChallengeRes.TabIndex = 0;
            btnAuthChallengeRes.Text = "Xác thực Challenge - Response";
            btnAuthChallengeRes.UseVisualStyleBackColor = true;
            btnAuthChallengeRes.Click += btnAuthChallengeRes_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Location = new Point(156, 14);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 120);
            panel3.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label10.ImeMode = ImeMode.NoControl;
            label10.Location = new Point(205, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(555, 53);
            label10.TabIndex = 0;
            label10.Text = "XÁC THỰC NGƯỜI DÙNG";
            // 
            // fAuthentication
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 696);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác thực";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnAuthChallengeRes;
        private Button btnAuthPublicKey;
        private Button btnAuthSym;
        private Panel panel3;
        private Label label10;
        private Button btnSimple;
        private Button button1;
        private Button btnHash;
    }
}