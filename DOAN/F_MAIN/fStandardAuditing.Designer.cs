namespace DOAN.F_MAIN
{
    partial class fStandardAuditing
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
            panel3 = new Panel();
            checkedListBox1 = new CheckedListBox();
            txtSql = new TextBox();
            dgvAudit = new DataGridView();
            btnRefresh = new Button();
            label2 = new Label();
            label7 = new Label();
            label10 = new Label();
            cmbUser = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            btnClose = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAudit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(txtSql);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(dgvAudit);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cmbUser);
            panel3.Location = new Point(101, 112);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(836, 584);
            panel3.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(261, 403);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(534, 158);
            checkedListBox1.TabIndex = 37;
            // 
            // txtSql
            // 
            txtSql.Location = new Point(149, 344);
            txtSql.Name = "txtSql";
            txtSql.Size = new Size(646, 27);
            txtSql.TabIndex = 36;
            // 
            // dgvAudit
            // 
            dgvAudit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAudit.Location = new Point(29, 82);
            dgvAudit.Name = "dgvAudit";
            dgvAudit.RowHeadersWidth = 51;
            dgvAudit.Size = new Size(766, 243);
            dgvAudit.TabIndex = 35;
            dgvAudit.CellContentClick += drgAudit_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Courier New", 12F);
            btnRefresh.Location = new Point(450, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 43);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label2.Location = new Point(29, 403);
            label2.Name = "label2";
            label2.Size = new Size(214, 23);
            label2.TabIndex = 31;
            label2.Text = "User Bị giám sát:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label7.Location = new Point(29, 345);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 31;
            label7.Text = "SQL Text:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label10.Location = new Point(29, 35);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 34;
            label10.Text = "User:";
            // 
            // cmbUser
            // 
            cmbUser.Font = new Font("Courier New", 12F);
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(105, 32);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(278, 30);
            cmbUser.TabIndex = 24;
            cmbUser.SelectedIndexChanged += cmbUser_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(85, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 74);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(44, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(667, 53);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra Audit giám sát";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Courier New", 12F);
            btnClose.Location = new Point(661, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 43);
            btnClose.TabIndex = 19;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fStandardAuditing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 726);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "fStandardAuditing";
            Text = "fStandardAuditing";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAudit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dgvAudit;
        private Label label7;
        private Label label10;
        private ComboBox cmbUser;
        private Panel panel1;
        private Label label1;
        private Button btnRefresh;
        private TextBox txtSql;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button btnClose;
    }
}