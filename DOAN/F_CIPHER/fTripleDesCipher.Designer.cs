namespace DOAN
{
    partial class fTripleDesCipher
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
            dtgvTable = new DataGridView();
            btnLoadData = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtPrivateKey = new TextBox();
            label3 = new Label();
            cbTableName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(399, 26);
            label1.Name = "label1";
            label1.Size = new Size(499, 53);
            label1.TabIndex = 0;
            label1.Text = "Triple DES Cipher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(57, 117);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 2;
            label2.Text = "Tên Bảng:";
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(73, 171);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(1068, 356);
            dtgvTable.TabIndex = 3;
            // 
            // btnLoadData
            // 
            btnLoadData.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnLoadData.Location = new Point(736, 110);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(184, 45);
            btnLoadData.TabIndex = 4;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnEncrypt.Location = new Point(211, 606);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(184, 45);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnDecrypt.Location = new Point(693, 606);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(184, 45);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(161, 546);
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.Size = new Size(980, 27);
            txtPrivateKey.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(57, 542);
            label3.Name = "label3";
            label3.Size = new Size(78, 31);
            label3.TabIndex = 2;
            label3.Text = "Key:";
            // 
            // cbTableName
            // 
            cbTableName.FormattingEnabled = true;
            cbTableName.Items.AddRange(new object[] { "TAIKHOAN", "THONGTINTK", "SANPHAM", "HOADON", "CHITIETHOADON" });
            cbTableName.Location = new Point(237, 117);
            cbTableName.Name = "cbTableName";
            cbTableName.Size = new Size(402, 28);
            cbTableName.TabIndex = 6;
            // 
            // fTripleDesCipher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 732);
            Controls.Add(cbTableName);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnLoadData);
            Controls.Add(dtgvTable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrivateKey);
            Controls.Add(label1);
            Name = "fTripleDesCipher";
            Text = "CipherOracle";
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dtgvTable;
        private Button btnLoadData;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtPrivateKey;
        private Label label3;
        private ComboBox cbTableName;
    }
}