namespace DOAN
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txbSid = new TextBox();
            label4 = new Label();
            txbPort = new TextBox();
            label3 = new Label();
            txbHost = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txbUsername = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbSid);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbPort);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txbHost);
            panel2.Controls.Add(label2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // txbSid
            // 
            resources.ApplyResources(txbSid, "txbSid");
            txbSid.Name = "txbSid";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txbPort
            // 
            resources.ApplyResources(txbPort, "txbPort");
            txbPort.Name = "txbPort";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txbHost
            // 
            resources.ApplyResources(txbHost, "txbHost");
            txbHost.Name = "txbHost";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbUsername);
            panel5.Controls.Add(label5);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // txbUsername
            // 
            resources.ApplyResources(txbUsername, "txbUsername");
            txbUsername.Name = "txbUsername";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnExit);
            panel7.Controls.Add(btnRegister);
            panel7.Controls.Add(btnLogin);
            resources.ApplyResources(panel7, "panel7");
            panel7.Name = "panel7";
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Cancel;
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHost;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private TextBox txbSid;
        private Label label4;
        private TextBox txbPort;
        private Label label3;
    }
}

