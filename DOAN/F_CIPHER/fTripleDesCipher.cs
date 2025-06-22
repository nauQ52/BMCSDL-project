using System;
using System.Data;
using System.Windows.Forms;
using DOAN.CIPHER;
using Microsoft.EntityFrameworkCore.Metadata;
using Oracle.ManagedDataAccess.Client;

namespace DOAN
{
    public partial class fTripleDesCipher : Form
    {
        OracleConnection conn;
        TripleDesOracle tripleDesOracle;

        public fTripleDesCipher()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect(); // Kết nối đến cơ sở dữ liệu
            tripleDesOracle = new TripleDesOracle(conn);
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
            //note 24 ky tu
            if (privateKey.Length != 24)
            {
                MessageBox.Show("Khóa phải có độ dài chính xác 24 ký tự.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string plaintext && !string.IsNullOrEmpty(plaintext))
                    {
                        byte[] encryptedText = tripleDesOracle.EncryptTripleDES(plaintext, privateKey);
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
            //note 24 ky tu
            if (privateKey.Length != 24)
            {
                MessageBox.Show("Khóa phải có độ dài chính xác 24 ký tự.");
                return;
            }



            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] != DBNull.Value && row[column] is string base64EncryptedText && !string.IsNullOrEmpty(base64EncryptedText))
                    {
                        try
                        {
                            byte[] encryptedText = Convert.FromBase64String(base64EncryptedText);
                            string decryptedText = tripleDesOracle.DecryptTripleDES(encryptedText, privateKey);

                            row[column] = decryptedText ?? "Giải mã thất bại";
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show($"Giá trị trong cột '{column.ColumnName}' không phải định dạng Base64 hợp lệ.");
                            row[column] = "Lỗi định dạng";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi giải mã dữ liệu cột '{column.ColumnName}': {ex.Message}");
                            row[column] = "Giải mã thất bại";
                        }
                    }
                }
            }

            dtgvTable.Refresh();
            MessageBox.Show("Giải mã dữ liệu hoàn tất!");
        }



    }
}
