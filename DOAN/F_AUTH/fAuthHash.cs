using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DOAN.F_AUTH
{
    public partial class fAuthHash : Form
    {
        private string host;
        private string port;
        private string sid;
        private string username;
        public fAuthHash(string Host, string Port, string Sid, string Username)
        {
            username = Username;
            host = Host;
            port = Port;
            sid = Sid;
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string password = txbPassword.Text;
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            string hasPass = hashSb.ToString();

            txbHash.Text = hasPass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hasPass = txbHash.Text;
            string pass = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Database.Get_connectSys();
            cmd.CommandText = "DOAN.SP_AUTHHASH";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter us = new OracleParameter();
            us.ParameterName = "@v_user";
            us.OracleDbType = OracleDbType.Varchar2;
            us.Value = username;
            us.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(us);

            OracleParameter mes = new OracleParameter();
            mes.ParameterName = "@v_Mes";
            mes.OracleDbType = OracleDbType.Varchar2;
            mes.Value = hasPass;
            mes.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(mes);

            OracleParameter passw = new OracleParameter();
            passw.ParameterName = "@v_pass";
            passw.OracleDbType = OracleDbType.Varchar2;
            passw.Size = 32767;
            passw.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(passw);

            cmd.ExecuteNonQuery();

            if (passw.Value != DBNull.Value)
            {
                OracleString ret = (OracleString)passw.Value;
                pass = ret.ToString();
            }

            Database.Set_Database(host, port, sid, username, pass);
            if (Database.Connect())
            {
                OracleConnection c = Database.Get_connect();
                Database.Close_connectSys();
                fProductManager f = new fProductManager(username);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo");
            }
        }
    }
}
