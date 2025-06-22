namespace DOAN.F_MAIN
{
    partial class fProductAdd
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
            btnThem = new Button();
            cboLoai = new ComboBox();
            txtMaSanPham = new TextBox();
            txtTenSanPham = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(327, 23);
            label1.Name = "label1";
            label1.Size = new Size(387, 53);
            label1.TabIndex = 0;
            label1.Text = "Thêm sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label2.Location = new Point(118, 114);
            label2.Name = "label2";
            label2.Size = new Size(235, 31);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label3.Location = new Point(118, 184);
            label3.Name = "label3";
            label3.Size = new Size(252, 31);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label4.Location = new Point(118, 260);
            label4.Name = "label4";
            label4.Size = new Size(184, 31);
            label4.TabIndex = 3;
            label4.Text = "Số lượng: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label5.Location = new Point(118, 332);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label6.Location = new Point(118, 405);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 5;
            label6.Text = "Loại: ";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(499, 460);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(198, 78);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboLoai
            // 
            cboLoai.Font = new Font("Courier New", 12F);
            cboLoai.FormattingEnabled = true;
            cboLoai.Items.AddRange(new object[] { "Sữa", "Snack", "Nước uống ", "Mì", "Văn phòng phẩm", "Bánh mì", "Kẹo", "Dầu gội - Sữa tắm", "Thực phẩm đông lạnh" });
            cboLoai.Location = new Point(427, 402);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(496, 30);
            cboLoai.TabIndex = 7;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Courier New", 12F);
            txtMaSanPham.Location = new Point(427, 114);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(496, 30);
            txtMaSanPham.TabIndex = 8;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Courier New", 12F);
            txtTenSanPham.Location = new Point(427, 181);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(496, 30);
            txtTenSanPham.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Courier New", 12F);
            txtSoLuong.Location = new Point(427, 257);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(496, 30);
            txtSoLuong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Courier New", 12F);
            txtDonGia.Location = new Point(427, 329);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(496, 30);
            txtDonGia.TabIndex = 11;
            // 
            // fProductAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 565);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(cboLoai);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fProductAdd";
            Text = "fProductAdd";
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
        private Button btnThem;
        private ComboBox cboLoai;
        private TextBox txtMaSanPham;
        private TextBox txtTenSanPham;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
    }
}