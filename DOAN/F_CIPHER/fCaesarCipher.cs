using DOAN.CIPHER;
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

namespace DOAN
{
    public partial class fCaesarCipher : Form
    {
        OracleConnection conn;
        CaesarCipherOracle caesarCipher;
        public fCaesarCipher()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect();
            caesarCipher = new CaesarCipherOracle(conn);
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

            if (!int.TryParse(txtKey.Text, out int key))
            {
                MessageBox.Show("Vui lòng nhập khóa hợp lệ.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string plaintext && !string.IsNullOrEmpty(plaintext))
                    {
                        string encryptedText = caesarCipher.EncryptCaesar(plaintext, key);
                        row[column] = encryptedText; 
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

            if (!int.TryParse(txtKey.Text, out int key))
            {
                MessageBox.Show("Vui lòng nhập khóa hợp lệ.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string ciphertext && !string.IsNullOrEmpty(ciphertext))
                    {
                        string decryptedText = caesarCipher.DecryptCaesar(ciphertext, key);
                        row[column] = decryptedText;
                    }
                }
            }

            dtgvTable.Refresh();
            MessageBox.Show("Giải mã dữ liệu thành công!");
        }
    }
}
