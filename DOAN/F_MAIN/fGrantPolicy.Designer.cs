namespace DOAN
{
    partial class fGrantPolicy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_Status = new Label();
            cboName = new ComboBox();
            btnCommit = new Button();
            rdbEnable = new CheckBox();
            rdbDisable = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(359, 53);
            label1.TabIndex = 0;
            label1.Text = "Gán Policy: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(222, 31);
            label2.TabIndex = 1;
            label2.Text = "Chọn Policy: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(530, 121);
            label3.Name = "label3";
            label3.Size = new Size(142, 31);
            label3.TabIndex = 2;
            label3.Text = "Status: ";
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            lb_Status.Location = new Point(678, 121);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(254, 31);
            lb_Status.TabIndex = 3;
            lb_Status.Text = "Hiện trạng thái";
            // 
            // cboName
            // 
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(240, 124);
            cboName.Name = "cboName";
            cboName.Size = new Size(232, 28);
            cboName.TabIndex = 4;
            // 
            // btnCommit
            // 
            btnCommit.Font = new Font("Courier New", 12F);
            btnCommit.Location = new Point(348, 338);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(166, 51);
            btnCommit.TabIndex = 7;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            // 
            // rdbEnable
            // 
            rdbEnable.AutoSize = true;
            rdbEnable.Font = new Font("Courier New", 10F);
            rdbEnable.Location = new Point(240, 211);
            rdbEnable.Name = "rdbEnable";
            rdbEnable.Size = new Size(91, 24);
            rdbEnable.TabIndex = 30;
            rdbEnable.Text = "Enable";
            rdbEnable.UseVisualStyleBackColor = true;
            // 
            // rdbDisable
            // 
            rdbDisable.AutoSize = true;
            rdbDisable.Font = new Font("Courier New", 10F);
            rdbDisable.Location = new Point(491, 211);
            rdbDisable.Name = "rdbDisable";
            rdbDisable.Size = new Size(101, 24);
            rdbDisable.TabIndex = 30;
            rdbDisable.Text = "Disable";
            rdbDisable.UseVisualStyleBackColor = true;
            // 
            // fGrantPolicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 478);
            Controls.Add(rdbDisable);
            Controls.Add(rdbEnable);
            Controls.Add(btnCommit);
            Controls.Add(cboName);
            Controls.Add(lb_Status);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fGrantPolicy";
            Text = "ganPolicy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_Status;
        private ComboBox cboName;
        private Button btnCommit;
        private CheckBox rdbEnable;
        private CheckBox rdbDisable;
    }
}