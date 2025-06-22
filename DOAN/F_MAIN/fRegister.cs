using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN
{
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
            Load_ComboBox();
        }
        bool Check_Textbox(string host, string port, string sid, string username, string password, string repassword)
        {
            if (host == "" || port == "" || sid == "" || username == "" || password == "" || repassword == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            else return true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string sid = txbSid.Text;
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string repassword = txbRePassword.Text;

            string tablespace = cboxTableSpace.SelectedItem.ToString();
            string quota = cboxQuota.SelectedItem.ToString();
            string profile = cboxProfile.SelectedItem.ToString();

            Database.Set_Database(host, port, sid, "", "");
            Database.ConnectSys();
            if (Check_Textbox(host, port, sid, username, password, repassword) && password == repassword)
            {
                try
                {
                    string Procedure = "SYS.SP_CREATEUSER";

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Database.Get_connectSys();
                    cmd.CommandText = Procedure;
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter us = new OracleParameter();
                    us.ParameterName = "@username";
                    us.OracleDbType = OracleDbType.Varchar2;
                    us.Value = username;
                    us.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(us);

                    OracleParameter pw = new OracleParameter();
                    pw.ParameterName = "@pass";
                    pw.OracleDbType = OracleDbType.Varchar2;
                    pw.Value = password;
                    pw.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(pw);

                    OracleParameter tblp = new OracleParameter();
                    tblp.ParameterName = "@tblspace";
                    tblp.OracleDbType = OracleDbType.Varchar2;
                    tblp.Value = tablespace;
                    tblp.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(tblp);

                    OracleParameter qt = new OracleParameter();
                    qt.ParameterName = "@quta";
                    qt.OracleDbType = OracleDbType.Varchar2;
                    qt.Value = quota;
                    qt.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(qt);

                    OracleParameter prof = new OracleParameter();
                    prof.ParameterName = "@prof";
                    prof.OracleDbType = OracleDbType.Varchar2;
                    prof.Value = profile;
                    prof.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(prof);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký thành công!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đăng kí thất bại", "Thông báo");
                }
                txbUsername.Clear();
                txbPassword.Clear();
                txbRePassword.Clear();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Database.Close_connectSys();
        }

        void Load_ComboBox()
        {
            Load_TableSpace();
            Load_Quota();
            Load_Profile();
        }

        void Load_TableSpace()
        {
            DataTable read = Database.Get_NameTableSpace();

            foreach (DataRow row in read.Rows)
            {
                cboxTableSpace.Items.Add(row[0]);
            }
            cboxTableSpace.SelectedIndex = 4;
        }

        void Load_Quota()
        {
            cboxQuota.Items.Add("5M");
            cboxQuota.Items.Add("10M");
            cboxQuota.SelectedIndex = 0;
        }
        void Load_Profile()
        {
            DataTable read = Database.Get_NameProfile();

            foreach (DataRow row in read.Rows)
            {
                cboxProfile.Items.Add(row[0]);
            }
            cboxProfile.SelectedIndex = 2;
        }
    }
}
