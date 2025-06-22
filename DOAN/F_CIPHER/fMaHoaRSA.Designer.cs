namespace DOAN
{
    partial class fMaHoaRSA
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
            txtPublicKey = new RichTextBox();
            txtPrivateKey = new RichTextBox();
            label3 = new Label();
            btnOpenPublicKey = new Button();
            btnOpenPrivateKey = new Button();
            btnGenerateKey = new Button();
            btnSaveKey = new Button();
            dtgvTable = new DataGridView();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label4 = new Label();
            btnLoadTable = new Button();
            cbTableName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(511, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 53);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa RSA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label2.Location = new Point(52, 84);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 1;
            label2.Text = "Public key:";
            // 
            // txtPublicKey
            // 
            txtPublicKey.Font = new Font("Courier New", 15.75F);
            txtPublicKey.Location = new Point(262, 87);
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.Size = new Size(862, 61);
            txtPublicKey.TabIndex = 2;
            txtPublicKey.Text = "";
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Font = new Font("Courier New", 15.75F);
            txtPrivateKey.Location = new Point(262, 179);
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.Size = new Size(862, 61);
            txtPrivateKey.TabIndex = 2;
            txtPrivateKey.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label3.Location = new Point(36, 182);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 3;
            label3.Text = "Private key:";
            // 
            // btnOpenPublicKey
            // 
            btnOpenPublicKey.Location = new Point(1151, 86);
            btnOpenPublicKey.Name = "btnOpenPublicKey";
            btnOpenPublicKey.Size = new Size(94, 38);
            btnOpenPublicKey.TabIndex = 5;
            btnOpenPublicKey.Text = "...";
            btnOpenPublicKey.UseVisualStyleBackColor = true;
            // 
            // btnOpenPrivateKey
            // 
            btnOpenPrivateKey.Location = new Point(1151, 179);
            btnOpenPrivateKey.Name = "btnOpenPrivateKey";
            btnOpenPrivateKey.Size = new Size(94, 38);
            btnOpenPrivateKey.TabIndex = 5;
            btnOpenPrivateKey.Text = "...";
            btnOpenPrivateKey.UseVisualStyleBackColor = true;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnGenerateKey.Location = new Point(352, 265);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(236, 38);
            btnGenerateKey.TabIndex = 5;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // btnSaveKey
            // 
            btnSaveKey.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnSaveKey.Location = new Point(811, 265);
            btnSaveKey.Name = "btnSaveKey";
            btnSaveKey.Size = new Size(236, 38);
            btnSaveKey.TabIndex = 5;
            btnSaveKey.Text = "Save Key";
            btnSaveKey.UseVisualStyleBackColor = true;
            btnSaveKey.Click += btnSaveKey_Click;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(262, 384);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.Size = new Size(862, 255);
            dtgvTable.TabIndex = 6;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnEncrypt.Location = new Point(352, 659);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(236, 38);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnDecrypt.Location = new Point(811, 659);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(236, 38);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            label4.Location = new Point(52, 331);
            label4.Name = "label4";
            label4.Size = new Size(190, 31);
            label4.TabIndex = 3;
            label4.Text = "Table name:";
            // 
            // btnLoadTable
            // 
            btnLoadTable.Font = new Font("Courier New", 15.75F, FontStyle.Bold);
            btnLoadTable.Location = new Point(604, 328);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(236, 38);
            btnLoadTable.TabIndex = 5;
            btnLoadTable.Text = "Load Data";
            btnLoadTable.UseVisualStyleBackColor = true;
            btnLoadTable.Click += btnLoadData_Click;
            // 
            // cbTableName
            // 
            cbTableName.FormattingEnabled = true;
            cbTableName.Items.AddRange(new object[] { "TAIKHOAN", "THONGTINTK", "SANPHAM", "HOADON", "CHITIETHOADON" });
            cbTableName.Location = new Point(262, 334);
            cbTableName.Name = "cbTableName";
            cbTableName.Size = new Size(298, 28);
            cbTableName.TabIndex = 7;
            // 
            // fMaHoaRSA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 793);
            Controls.Add(cbTableName);
            Controls.Add(dtgvTable);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnLoadTable);
            Controls.Add(btnSaveKey);
            Controls.Add(btnGenerateKey);
            Controls.Add(btnOpenPrivateKey);
            Controls.Add(btnOpenPublicKey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrivateKey);
            Controls.Add(txtPublicKey);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fMaHoaRSA";
            Text = "fMaHoaRSA";
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox txtPublicKey;
        private RichTextBox txtPrivateKey;
        private Label label3;
        private Button btnOpenPublicKey;
        private Button btnOpenPrivateKey;
        private Button btnGenerateKey;
        private Button btnSaveKey;
        private DataGridView dtgvTable;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label4;
        private Button btnLoadTable;
        private ComboBox cbTableName;
    }
}