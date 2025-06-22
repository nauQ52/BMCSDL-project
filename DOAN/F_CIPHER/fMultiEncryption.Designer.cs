namespace DOAN.F_CIPHER
{
    partial class fMultiEncryption
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
            cbTableName = new ComboBox();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            btnLoadData = new Button();
            dtgvTable = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            txtKey = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            SuspendLayout();
            // 
            // cbTableName
            // 
            cbTableName.FormattingEnabled = true;
            cbTableName.Items.AddRange(new object[] { "TAIKHOAN", "THONGTINTK", "SANPHAM", "HOADON", "CHITIETHOADON" });
            cbTableName.Location = new Point(213, 128);
            cbTableName.Name = "cbTableName";
            cbTableName.Size = new Size(273, 28);
            cbTableName.TabIndex = 14;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnDecrypt.Location = new Point(685, 617);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(184, 45);
            btnDecrypt.TabIndex = 11;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnEncrypt.Location = new Point(203, 617);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(184, 45);
            btnEncrypt.TabIndex = 12;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnLoadData.Location = new Point(728, 121);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(184, 45);
            btnLoadData.TabIndex = 13;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(65, 182);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(1068, 356);
            dtgvTable.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(49, 553);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 8;
            label3.Text = "Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(49, 128);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 9;
            label2.Text = "Tên Bảng:";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(153, 557);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(980, 27);
            txtKey.TabIndex = 7;
            txtKey.Text = "7\r\n\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(391, 37);
            label1.Name = "label1";
            label1.Size = new Size(359, 53);
            label1.TabIndex = 6;
            label1.Text = "Multi Cipher";
            // 
            // fMultiEncryption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 698);
            Controls.Add(cbTableName);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnLoadData);
            Controls.Add(dtgvTable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKey);
            Controls.Add(label1);
            Name = "fMultiEncryption";
            Text = "MU";
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTableName;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnLoadData;
        private DataGridView dtgvTable;
        private Label label3;
        private Label label2;
        private TextBox txtKey;
        private Label label1;
    }
}