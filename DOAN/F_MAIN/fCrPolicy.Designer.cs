namespace DOAN
{
    partial class fCrPolicy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnThem = new Button();
            btnGan = new Button();
            txtName1 = new TextBox();
            txtNameColumn = new TextBox();
            cboName = new ComboBox();
            cboUser = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(191, 37);
            label1.Name = "label1";
            label1.Size = new Size(863, 53);
            label1.TabIndex = 0;
            label1.Text = "Tạo Policy - Gán quyền quản lý";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(704, 165);
            label2.Name = "label2";
            label2.Size = new Size(286, 31);
            label2.TabIndex = 1;
            label2.Text = "Gán quyền quản lí";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(129, 165);
            label3.Name = "label3";
            label3.Size = new Size(238, 31);
            label3.TabIndex = 2;
            label3.Text = "Tên chính sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label4.Location = new Point(592, 275);
            label4.Name = "label4";
            label4.Size = new Size(206, 31);
            label4.TabIndex = 3;
            label4.Text = "Tên Policy: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label5.Location = new Point(129, 275);
            label5.Name = "label5";
            label5.Size = new Size(206, 31);
            label5.TabIndex = 4;
            label5.Text = "Tên Policy: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.Location = new Point(113, 378);
            label6.Name = "label6";
            label6.Size = new Size(222, 31);
            label6.TabIndex = 5;
            label6.Text = "Tên Cột OLS: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label7.Location = new Point(560, 378);
            label7.Name = "label7";
            label7.Size = new Size(254, 31);
            label7.TabIndex = 6;
            label7.Text = "Nhập Tên User: ";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Courier New", 12F);
            btnThem.Location = new Point(291, 495);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(182, 65);
            btnThem.TabIndex = 7;
            btnThem.Text = "Tạo";
            btnThem.UseVisualStyleBackColor = true;

            // 
            // btnGan
            // 
            btnGan.Font = new Font("Courier New", 12F);
            btnGan.Location = new Point(643, 495);
            btnGan.Name = "btnGan";
            btnGan.Size = new Size(171, 65);
            btnGan.TabIndex = 8;
            btnGan.Text = "Gán";
            btnGan.UseVisualStyleBackColor = true;
            btnGan.Click += btnGan_Click;
            // 
            // txtName1
            // 
            txtName1.Location = new Point(341, 275);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(188, 27);
            txtName1.TabIndex = 9;
            // 
            // txtNameColumn
            // 
            txtNameColumn.Location = new Point(341, 378);
            txtNameColumn.Name = "txtNameColumn";
            txtNameColumn.Size = new Size(188, 27);
            txtNameColumn.TabIndex = 10;
            // 
            // cboName
            // 
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(804, 274);
            cboName.Name = "cboName";
            cboName.Size = new Size(221, 28);
            cboName.TabIndex = 11;
            // 
            // cboUser
            // 
            cboUser.FormattingEnabled = true;
            cboUser.Location = new Point(804, 381);
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(221, 28);
            cboUser.TabIndex = 12;
            // 
            // fCrPolicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 711);
            Controls.Add(cboUser);
            Controls.Add(cboName);
            Controls.Add(txtNameColumn);
            Controls.Add(txtName1);
            Controls.Add(btnGan);
            Controls.Add(btnThem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fCrPolicy";
            Text = "fCrPolicy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnThem;
        private Button btnGan;
        private TextBox txtName1;
        private TextBox txtNameColumn;
        private ComboBox cboName;
        private ComboBox cboUser;
    }
}
