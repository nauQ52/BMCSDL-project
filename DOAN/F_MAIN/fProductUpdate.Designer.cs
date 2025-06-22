namespace DOAN.F_MAIN
{
    partial class fProductUpdate
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
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenSanPham = new TextBox();
            txtMaSanPham = new TextBox();
            cboLoai = new ComboBox();
            btnSua = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Courier New", 12F);
            txtDonGia.Location = new Point(422, 348);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(520, 30);
            txtDonGia.TabIndex = 23;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Courier New", 12F);
            txtSoLuong.Location = new Point(422, 276);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(520, 30);
            txtSoLuong.TabIndex = 22;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Courier New", 12F);
            txtTenSanPham.Location = new Point(422, 200);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(520, 30);
            txtTenSanPham.TabIndex = 21;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Courier New", 12F);
            txtMaSanPham.Location = new Point(422, 133);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(520, 30);
            txtMaSanPham.TabIndex = 20;
            // 
            // cboLoai
            // 
            cboLoai.Font = new Font("Courier New", 12F);
            cboLoai.FormattingEnabled = true;
            cboLoai.Items.AddRange(new object[] { "Sữa", "Snack", "Nước uống ", "Mì", "Văn phòng phẩm", "Bánh mì", "Kẹo", "Dầu gội - Sữa tắm", "Thực phẩm đông lạnh" });
            cboLoai.Location = new Point(422, 421);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(520, 30);
            cboLoai.TabIndex = 19;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(422, 516);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(245, 61);
            btnSua.TabIndex = 18;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label6.Location = new Point(113, 424);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 17;
            label6.Text = "Loại: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label5.Location = new Point(113, 351);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 16;
            label5.Text = "Đơn giá: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label4.Location = new Point(113, 279);
            label4.Name = "label4";
            label4.Size = new Size(184, 31);
            label4.TabIndex = 15;
            label4.Text = "Số lượng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label3.Location = new Point(113, 203);
            label3.Name = "label3";
            label3.Size = new Size(252, 31);
            label3.TabIndex = 14;
            label3.Text = "Tên sản phẩm: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label2.Location = new Point(113, 133);
            label2.Name = "label2";
            label2.Size = new Size(235, 31);
            label2.TabIndex = 13;
            label2.Text = "Mã sản phẩm: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(263, 26);
            label1.Name = "label1";
            label1.Size = new Size(499, 53);
            label1.TabIndex = 12;
            label1.Text = "Cập nhật sản phẩm";
            // 
            // fProductUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 634);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(cboLoai);
            Controls.Add(btnSua);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fProductUpdate";
            Text = "fProductUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtTenSanPham;
        private TextBox txtMaSanPham;
        private ComboBox cboLoai;
        private Button btnSua;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}