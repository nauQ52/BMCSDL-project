namespace DOAN
{
    partial class fCrOracleLableSecurity
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCreate = new Button();
            btnClose = new Button();
            cboPolicy = new ComboBox();
            cboThanhPhan = new ComboBox();
            cboChiTiet = new ComboBox();
            txtNumber = new TextBox();
            txtShortName = new TextBox();
            txtLongName = new TextBox();
            cbo_groupParent = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(171, 35);
            label1.Name = "label1";
            label1.Size = new Size(723, 53);
            label1.TabIndex = 0;
            label1.Text = "Tạo Oracle Label Security";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(203, 132);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 1;
            label2.Text = "Chọn Policy:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(46, 220);
            label3.Name = "label3";
            label3.Size = new Size(270, 31);
            label3.TabIndex = 2;
            label3.Text = "Chọn thành phần:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label4.Location = new Point(614, 220);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 3;
            label4.Text = "Chi tiết: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label5.Location = new Point(203, 283);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 4;
            label5.Text = "Number: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label6.Location = new Point(203, 359);
            label6.Name = "label6";
            label6.Size = new Size(206, 31);
            label6.TabIndex = 5;
            label6.Text = "Short Name: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label7.Location = new Point(207, 430);
            label7.Name = "label7";
            label7.Size = new Size(190, 31);
            label7.TabIndex = 6;
            label7.Text = "Long Name: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label8.Location = new Point(207, 499);
            label8.Name = "label8";
            label8.Size = new Size(206, 31);
            label8.TabIndex = 7;
            label8.Text = "Parent Name:";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Courier New", 12F);
            btnCreate.Location = new Point(209, 605);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 42);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Courier New", 12F);
            btnClose.Location = new Point(626, 605);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(201, 42);
            btnClose.TabIndex = 9;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // cboPolicy
            // 
            cboPolicy.FormattingEnabled = true;
            cboPolicy.Location = new Point(479, 132);
            cboPolicy.Name = "cboPolicy";
            cboPolicy.Size = new Size(256, 28);
            cboPolicy.TabIndex = 10;
            // 
            // cboThanhPhan
            // 
            cboThanhPhan.FormattingEnabled = true;
            cboThanhPhan.Location = new Point(322, 220);
            cboThanhPhan.Name = "cboThanhPhan";
            cboThanhPhan.Size = new Size(256, 28);
            cboThanhPhan.TabIndex = 11;
            // 
            // cboChiTiet
            // 
            cboChiTiet.FormattingEnabled = true;
            cboChiTiet.Location = new Point(794, 220);
            cboChiTiet.Name = "cboChiTiet";
            cboChiTiet.Size = new Size(238, 28);
            cboChiTiet.TabIndex = 12;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(479, 287);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(256, 27);
            txtNumber.TabIndex = 13;
            // 
            // txtShortName
            // 
            txtShortName.Location = new Point(479, 359);
            txtShortName.Name = "txtShortName";
            txtShortName.Size = new Size(256, 27);
            txtShortName.TabIndex = 14;
            // 
            // txtLongName
            // 
            txtLongName.Location = new Point(479, 430);
            txtLongName.Name = "txtLongName";
            txtLongName.Size = new Size(256, 27);
            txtLongName.TabIndex = 15;
            // 
            // cbo_groupParent
            // 
            cbo_groupParent.FormattingEnabled = true;
            cbo_groupParent.Location = new Point(479, 502);
            cbo_groupParent.Name = "cbo_groupParent";
            cbo_groupParent.Size = new Size(256, 28);
            cbo_groupParent.TabIndex = 16;
            // 
            // TaoOracleLableSecurity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 712);
            Controls.Add(cbo_groupParent);
            Controls.Add(txtLongName);
            Controls.Add(txtShortName);
            Controls.Add(txtNumber);
            Controls.Add(cboChiTiet);
            Controls.Add(cboThanhPhan);
            Controls.Add(cboPolicy);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaoOracleLableSecurity";
            Text = "TaoOracleLableSecurity";
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
        private Label label8;
        private Button btnCreate;
        private Button btnClose;
        private ComboBox cboPolicy;
        private ComboBox cboThanhPhan;
        private ComboBox cboChiTiet;
        private TextBox txtNumber;
        private TextBox txtShortName;
        private TextBox txtLongName;
        private ComboBox cbo_groupParent;
    }
}