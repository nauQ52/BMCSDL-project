using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.F_MAIN
{
    public partial class fProductDelete : Form
    {
        public fProductDelete()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void fProductDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txtMaSanPham.Text.Trim();

            // Kiểm tra nếu mã sản phẩm bị bỏ trống
            if (string.IsNullOrEmpty(masp))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            DialogResult confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm có mã '{masp}' không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return; // Người dùng không xác nhận xóa
            }

            try
            {
                string Procedure = "DELETE_SANPHAM";

                OracleCommand cmd = new OracleCommand
                {
                    Connection = Database.Get_connect(),
                    CommandText = Procedure,
                    CommandType = CommandType.StoredProcedure
                };

                // Thêm tham số mã sản phẩm
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_MASP",
                    OracleDbType = OracleDbType.Varchar2,
                    Value = masp,
                    Direction = ParameterDirection.Input
                });

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
