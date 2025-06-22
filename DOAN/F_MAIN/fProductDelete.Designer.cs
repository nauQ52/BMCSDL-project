namespace DOAN.F_MAIN
{
    partial class fProductDelete
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
            txtMaSanPham = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Font = new Font("Courier New", 12F);
            txtMaSanPham.Location = new Point(340, 171);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(395, 30);
            txtMaSanPham.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 16.2F, FontStyle.Bold);
            label2.Location = new Point(64, 168);
            label2.Name = "label2";
            label2.Size = new Size(235, 31);
            label2.TabIndex = 10;
            label2.Text = "Mã sản phẩm: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.Location = new Point(253, 37);
            label1.Name = "label1";
            label1.Size = new Size(359, 53);
            label1.TabIndex = 9;
            label1.Text = "Xóa sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Courier New", 12F);
            btnXoa.Location = new Point(340, 272);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(149, 58);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // fProductDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(txtMaSanPham);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fProductDelete";
            Text = "fProductDelete";
            Load += fProductDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSanPham;
        private Label label2;
        private Label label1;
        private Button btnXoa;
    }
}