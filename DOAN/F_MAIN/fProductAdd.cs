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
using Oracle.ManagedDataAccess;

namespace DOAN.F_MAIN
{
    public partial class fProductAdd : Form
    {
        public fProductAdd()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masp = txtMaSanPham.Text.Trim();
            string tensp = txtTenSanPham.Text.Trim();
            string dongiaText = txtDonGia.Text.Trim();
            string soluongText = txtSoLuong.Text.Trim();
            string loaisp = cboLoai.Text.Trim();

            if (string.IsNullOrEmpty(masp) || string.IsNullOrEmpty(tensp) || string.IsNullOrEmpty(loaisp) ||
                string.IsNullOrEmpty(dongiaText) || string.IsNullOrEmpty(soluongText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(dongiaText, out float dongia) || !int.TryParse(soluongText, out int soluong))
            {
                MessageBox.Show("Đơn giá và số lượng phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string Procedure = "ADD_SANPHAM";

                OracleCommand cmd = new OracleCommand
                {
                    Connection = Database.Get_connect(),
                    CommandText = Procedure,
                    CommandType = CommandType.StoredProcedure
                };

                // Thêm tham số
                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_MASP",
                    OracleDbType = OracleDbType.Varchar2,
                    Value = masp,
                    Direction = ParameterDirection.Input
                });

                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_TENSP",
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = tensp,
                    Direction = ParameterDirection.Input
                });

                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_DONGIA",
                    OracleDbType = OracleDbType.Int32,
                    Value = dongia,
                    Direction = ParameterDirection.Input
                });

                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_SOLUONG",
                    OracleDbType = OracleDbType.Int32,
                    Value = soluong,
                    Direction = ParameterDirection.Input
                });

                cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "P_LOAISP",
                    OracleDbType = OracleDbType.NVarchar2,
                    Value = loaisp,
                    Direction = ParameterDirection.Input
                });

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
