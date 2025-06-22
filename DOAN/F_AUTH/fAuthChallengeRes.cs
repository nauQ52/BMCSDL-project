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
using System.Security.Policy;
using Oracle.ManagedDataAccess.Types;

namespace DOAN
{
    public partial class fAuthChallengeRes : Form
    {
        private string host;
        private string port;
        private string sid;
        private string username;
        public fAuthChallengeRes(string Host, string Port, string Sid, string Username)
        {
            username = Username;
            host = Host;
            port = Port;
            sid = Sid;
            InitializeComponent();
            txbNonce.Text = getNonce();
        }

        private string getNonce()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Database.Get_connectSys();
            cmd.CommandText = "DOAN.SP_RANDOMNONCE";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter nonce = new OracleParameter();
            nonce.ParameterName = "@nonce";
            nonce.OracleDbType = OracleDbType.Varchar2;
            nonce.Size = 5;
            nonce.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(nonce);

            cmd.ExecuteNonQuery();

            string N = "null";

            if (nonce.Value != DBNull.Value)
            {
                OracleString ret = (OracleString) nonce.Value;
                N = ret.ToString();
            }

            return N;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string password = txbPassword.Text;
            string nonce = txbNonce.Text;
            string mes = password + nonce;
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(mes));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            string hashMes = hashSb.ToString();

            txbAuthChallengeRes.Text = hashMes;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string N = txbNonce.Text;
            string M = txbAuthChallengeRes.Text;
            string pass = "";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Database.Get_connectSys();
            cmd.CommandText = "DOAN.SP_AUTHCHALLENGERES";
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
            mes.Value = M;
            mes.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(mes);

            OracleParameter nonce = new OracleParameter();
            nonce.ParameterName = "@v_Nonce";
            nonce.OracleDbType = OracleDbType.Varchar2;
            nonce.Value = N;
            nonce.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(nonce);

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
