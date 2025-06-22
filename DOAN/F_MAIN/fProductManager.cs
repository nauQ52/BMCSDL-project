using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Timers;
using DOAN.CIPHER;
using DOAN.F_MAIN;
using DOAN.F_CIPHER;
using DOAN;


namespace DOAN
{
    public partial class fProductManager : Form
    {
        private string username;
        private System.Timers.Timer timer;

        OracleConnection conn;
        CaesarCipherOracle caesarCipherOracle;
        MultiEncryptionOracle multiEncryptionOracle;
        DesOracle DESOracle;
        public fProductManager(string Username)
        {
            username = Username;
            InitializeComponent();
            LoadList(Username);
            conn = Database.Get_connect();
            caesarCipherOracle = new CaesarCipherOracle(conn);
            multiEncryptionOracle = new MultiEncryptionOracle(conn);
            DESOracle = new DesOracle(conn);
            InitializeSessionCheckTimer();
        }
        void LoadList(string username)
        {
            LoadProduct(username);
            LoadBill(username);
            LoadAccount(username);
        }
        void LoadProduct(string username)
        {
            //string query = "SELECT DOAN.DES.encrypt(MASP, 'NHOM1111') as MASP, DOAN.CAESARCIPHER.encrypt(TENSP, 1111) as TENSP, DONGIA, SOLUONG, DOAN.MULTIENCRYPTION.encrypt(LOAISP, 1111) as LOAISP FROM DOAN.SANPHAM";
            string query = "SELECT MASP, TENSP, DONGIA, SOLUONG, LOAISP FROM DOAN.SANPHAM";
            try
            {
                using (OracleDataAdapter data = new OracleDataAdapter(query, Database.Get_connect()))
                {
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    dtgvProduct.DataSource = dataTable;
                    dtgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dtgvProduct.Columns["TENSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có quyền truy cập vào SẢN PHẨM", "Thông báo");
            }
        }
        void LoadBill(string username)
        {
            string query = "SELECT * FROM DOAN.HOADON";

            try
            {
                using (OracleDataAdapter data = new OracleDataAdapter(query, Database.Get_connect()))
                {
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    dtgvBill.DataSource = dataTable;
                    dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgvBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dtgvBill.Columns["TONGTIEN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có quyền truy cập vào HÓA ĐƠN", "Thông báo");
            }
        }
        void LoadAccount(string username)
        {
            string query = "SELECT * FROM DOAN.TAIKHOAN";

            try
            {
                using (OracleDataAdapter data = new OracleDataAdapter(query, Database.Get_connect()))
                {
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    dtgvAccount.DataSource = dataTable;
                    dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dtgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dtgvAccount.Columns["TENDANGNHAP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có quyền truy cập vào TÀI KHOẢN", "Thông báo");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fProductAdd f = new fProductAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            fProductDelete f = new fProductDelete();

            f.ShowDialog();
            this.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            fProductUpdate f = new fProductUpdate();

            f.ShowDialog();
            this.Show();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBill_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {

        }
        private void dtgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvProduct.Rows[e.RowIndex];

                txbProductName.Text = row.Cells["TENSP"].Value.ToString();
                txbProductCategory.Text = row.Cells["LOAISP"].Value.ToString();
                nmrPrice.Value = Convert.ToDecimal(row.Cells["DONGIA"].Value);
                nmrQuantity.Value = Convert.ToDecimal(row.Cells["SOLUONG"].Value);
            }
        }
        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBill.Rows[e.RowIndex];

                txbBillID.Text = row.Cells["MAHD"].Value.ToString();
                txbBillAccountID.Text = row.Cells["MATK"].Value.ToString();

            }
        }
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];

                txbAccountID.Text = row.Cells["MATK"].Value.ToString();
                txbAccountName.Text = row.Cells["TENDANGNHAP"].Value.ToString();

            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logOut == DialogResult.Yes)
            {
                try
                {
                    Database.ConnectSys();

                    using (OracleCommand cmd = new OracleCommand("SYS.SP_LOGOUTUSER", Database.Get_connectSys()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_username", OracleDbType.NVarchar2).Value = username;

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
                finally
                {
                    Database.Close_connectSys();
                }
            }
        }
        private bool IsSessionKilled()
        {
            try
            {
                string connString = @"Data Source=localhost:1521/orcl;Persist Security Info=True;User ID=sys;Password=sys;DBA Privilege = SYSDBA;";
                using (OracleConnection connection = new OracleConnection(connString))
                {
                    connection.Open();

                    string checkSessionQuery = $"SELECT COUNT(*) FROM v$session WHERE username = '{username.ToUpper()}'";
                    OracleCommand command = new OracleCommand(checkSessionQuery, connection);

                    int sessionCount = Convert.ToInt32(command.ExecuteScalar());

                    return sessionCount == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi check Session: " + ex.Message);
                timer.Stop();
                return false;
            }
        }
        private void OnSessionCheck(Object source, ElapsedEventArgs e)
        {
            if (IsSessionKilled())
            {
                timer.Stop();
                MessageBox.Show("Tài khoản đã đăng xuất", "Thông báo");
                this.Invoke(new Action(() =>
                {
                    this.Hide(); // Đóng form hoặc thực thi hành động khác
                }));
            }
        }
        private void InitializeSessionCheckTimer()
        {
            timer = new System.Timers.Timer(100);
            timer.Elapsed += OnSessionCheck;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void btnEncryptProduct_Click(object sender, EventArgs e)
        {
            string tensp = txbProductName.Text;
            string loaisp = txbProductCategory.Text;

            string keyDES = "NHOM1111";
            int keyCaesar = 1111;

            byte[] b = DESOracle.EncryptDES(tensp, keyDES);
            string kq = caesarCipherOracle.EncryptCaesar(loaisp, keyCaesar);

            txbProductName.Text = Convert.ToBase64String(b);
            txbProductCategory.Text = kq;
        }
        private void btnDecryptProduct_Click(object sender, EventArgs e)
        {
            string tensp = txbProductName.Text;
            string loaisp = txbProductCategory.Text;

            string keyDES = "NHOM1111";
            int keyCaesar = 1111;

            byte[] b = Convert.FromBase64String(tensp);
            string kq = caesarCipherOracle.DecryptCaesar(loaisp, keyCaesar);

            txbProductName.Text = DESOracle.DecryptDES(b, keyDES);
            txbProductCategory.Text = kq;
        }

        private void btnCallRSATable_Click(object sender, EventArgs e)
        {
            fMaHoaRSA f = new fMaHoaRSA();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCeasarCipher_Click(object sender, EventArgs e)
        {
            fCaesarCipher f = new fCaesarCipher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDesCipher_Click(object sender, EventArgs e)
        {
            fDesCipher f = new fDesCipher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTripleDesCipher_Click(object sender, EventArgs e)
        {
            fTripleDesCipher f = new fTripleDesCipher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnMultiCipher_Click(object sender, EventArgs e)
        {
            fMultiEncryption f = new fMultiEncryption();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            fGrantGUI f = new fGrantGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnPolicy_Click(object sender, EventArgs e)
        {
            fCrPolicy f = new fCrPolicy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGrPolicy_Click(object sender, EventArgs e)
        {
            fGrantPolicy f = new fGrantPolicy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnGrantGUI_Click(object sender, EventArgs e)
        {
            fGrantGUI f = new fGrantGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            fStandardAuditing f = new fStandardAuditing();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
