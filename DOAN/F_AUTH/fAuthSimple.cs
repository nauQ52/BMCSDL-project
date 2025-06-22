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

namespace DOAN.F_AUTH
{
    public partial class fAuthSimple : Form
    {
        private string host;
        private string port;
        private string sid;
        private string username;
        public fAuthSimple(string Host, string Port, string Sid, string Username)
        {
            username = Username;
            host = Host;
            port = Port;
            sid = Sid;
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = txbPassword.Text;
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
