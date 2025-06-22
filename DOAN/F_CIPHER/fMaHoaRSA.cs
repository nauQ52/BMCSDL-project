using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using DOAN.CIPHER;

namespace DOAN
{
    public partial class fMaHoaRSA : Form
    {
        OracleConnection conn;
        RSAOracle RSA;

        public fMaHoaRSA()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect();
            RSA = new RSAOracle(conn);
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            try
            {
                string key = RSA.generateKey(1024);

                string[] keyPair = key.Split(new string[] {
                "****publicKey start*****",
                "****publicKey end**** ****privateKey start****",
                "****privateKey end**** do not copy asteric(*) ****"}, StringSplitOptions.RemoveEmptyEntries);

                txtPublicKey.Text = keyPair[0].Trim();
                txtPrivateKey.Text = keyPair[1].Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (txtPublicKey.Text == "" || txtPrivateKey.Text == "")
            {
                MessageBox.Show("Vui lòng tạo khóa và nhập cả khóa công khai và khóa bí mật."); return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.Title = "Save Keys";

                string uniqueFileName = string.Format("Keys_{0}", Path.GetRandomFileName().Substring(0, 8));

                saveFileDialog.FileName = uniqueFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string publickeyFilePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_publickey.txt");
                    File.WriteAllText(publickeyFilePath, txtPublicKey.Text);

                    string privateKeyFilePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_privatekey.txt");
                    File.WriteAllText(privateKeyFilePath, txtPrivateKey.Text);

                    MessageBox.Show("Đã lưu khóa công khai và khóa bí mật thành công.");
                }
            }
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
                if (Database.Get_connect() == null || Database.Get_connect().State != ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối đến cơ sở dữ liệu chưa được mở.");
                    return;
                }

                string query = $"SELECT * FROM \"{tableName}\"";

                OracleDataAdapter adapter = new OracleDataAdapter(query, Database.Get_connect());
                //luu data vao datatable
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

            if (string.IsNullOrEmpty(txtPublicKey.Text))
            {
                MessageBox.Show("Vui lòng nhập khóa công khai.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string plaintext && !string.IsNullOrEmpty(plaintext))
                    {
                        try
                        {
                            string pubKey = txtPublicKey.Text;

                            byte[] data = Encoding.UTF8.GetBytes(plaintext);
                            int maxBlockSize = 1024 / 8 - 42;

                            List<byte> encryptData = new List<byte>();

                            for (int i = 0; i < data.Length; i += maxBlockSize)
                            {
                                int blockSize = Math.Min(maxBlockSize, data.Length - i);
                                byte[] block = new byte[blockSize];
                                Array.Copy(data, i, block, 0, blockSize);

                                string encryptedBlockBase64 = RSA.encrypt(Convert.ToBase64String(block), pubKey);
                                byte[] encryptedBytes = Convert.FromBase64String(encryptedBlockBase64);
                                encryptData.AddRange(encryptedBytes);
                            }

                            string entext = Convert.ToBase64String(encryptData.ToArray());
                            row[column] = entext;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi mã hóa: " + ex.Message);
                        }
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

            if (string.IsNullOrEmpty(txtPrivateKey.Text))
            {
                MessageBox.Show("Vui lòng nhập khóa bí mật.");
                return;
            }

            DataTable dataTable = (DataTable)dtgvTable.DataSource;

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column] is string ciphertext && !string.IsNullOrEmpty(ciphertext))
                    {
                        try
                        {
                            string priKey = txtPrivateKey.Text;

                            byte[] encryptedData = Convert.FromBase64String(ciphertext);
                            int maxBlockSize = 128;
                            List<byte> decryptedData = new List<byte>();

                            for (int i = 0; i < encryptedData.Length; i += maxBlockSize)
                            {
                                int blockSize = Math.Min(maxBlockSize, encryptedData.Length - i);
                                byte[] block = new byte[blockSize];
                                Array.Copy(encryptedData, i, block, 0, blockSize);

                                string decryptedBlockBase64 = RSA.decrypt(Convert.ToBase64String(block), priKey);
                                byte[] decryptedBytes = Convert.FromBase64String(decryptedBlockBase64);
                                decryptedData.AddRange(decryptedBytes);
                            }

                            string decryptedText = Encoding.UTF8.GetString(decryptedData.ToArray());
                            row[column] = decryptedText;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi giải mã: " + ex.Message);
                        }
                    }
                }
            }

            dtgvTable.Refresh();
            MessageBox.Show("Giải mã dữ liệu thành công!");
        }




    }
}
