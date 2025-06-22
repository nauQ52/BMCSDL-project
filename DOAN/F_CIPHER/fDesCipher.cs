using System;
using System.Data;
using System.Windows.Forms;
using DOAN.CIPHER;
using Oracle.ManagedDataAccess.Client;

namespace DOAN
{
    public partial class fDesCipher : Form
    {
        OracleConnection conn;
        DesOracle desOracle;

        public fDesCipher()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect(); // Kết nối đến cơ sở dữ liệu
            desOracle = new DesOracle(conn);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string tableName = cbTableName.Text.Trim();

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Vui lòng nhập tên bảng.");
                return;
            }

            LoadDataFromTable(tableName);
        }

        private void LoadDataFromTable(string tableName)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối đến cơ sở dữ liệu chưa được mở.");
                    return;
                }

                string query = $"SELECT * FROM \"{tableName}\"";
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dtgvTable.DataSource = dataTable;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (dtgvTable.DataSource == null)
            {
                MessageBox.Show("Vui lòng tải dữ liệu từ bảng trước.");
                return;
            }

            string privateKey = txtPrivateKey.Text.Trim();
            if (string.IsNullOrEmpty(privateKey))
            {
                MessageBox.Show("Vui lòng nhập khóa riêng.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string plaintext && !string.IsNullOrEmpty(plaintext))
                    {
                        byte[] encryptedText = desOracle.EncryptDES(plaintext, privateKey);
                        row[column] = encryptedText != null ? Convert.ToBase64String(encryptedText) : null; 
                    }
                }
            }

            dtgvTable.Refresh(); 
            MessageBox.Show("Mã hóa dữ liệu thành công!");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (dtgvTable.DataSource == null)
            {
                MessageBox.Show("Vui lòng tải dữ liệu từ bảng trước.");
                return;
            }

            string privateKey = txtPrivateKey.Text.Trim();
            if (string.IsNullOrEmpty(privateKey))
            {
                MessageBox.Show("Vui lòng nhập khóa riêng.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string base64EncryptedText && !string.IsNullOrEmpty(base64EncryptedText))
                    {
                        try
                        {
                            byte[] encryptedText = Convert.FromBase64String(base64EncryptedText);
                            
                            string decryptedText = desOracle.DecryptDES(encryptedText, privateKey);
                            
                            row[column] = decryptedText ?? "Giải mã thất bại";
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show($"Giá trị trong cột '{column.ColumnName}' không phải là định dạng Base64 hợp lệ.");
                            row[column] = "Lỗi định dạng"; 
                        }
                        catch (OracleException oraEx)
                        {
                            MessageBox.Show($"Lỗi Oracle: {oraEx.Message}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi giải mã dữ liệu: {ex.Message}");
                        }
                    }
                }
            }

            dtgvTable.Refresh(); 
            MessageBox.Show("Giải mã dữ liệu hoàn tất!");
        }


    }
}
