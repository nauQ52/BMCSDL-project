using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using Oracle.ManagedDataAccess.Types;
using System.Security.Policy;
using Microsoft.VisualBasic.ApplicationServices;

namespace DOAN
{
    public partial class fLogin : Form
    {
        public fLogin()
        {

            InitializeComponent();
        }
        bool Check_Textbox(string host, string port, string sid, string user)
        {
            if (host == "")
            {
                MessageBox.Show("Chưa điền thông tin Host");
                txbHost.Focus();
                return false;
            }
            else if (port == "")
            {
                MessageBox.Show("Chưa điền thông tin Port");
                txbPort.Focus();
                return false;
            }
            else if (sid == "")
            {
                MessageBox.Show("Chưa điền thông tin SID");
                txbSid.Focus();
                return false;
            }
            else if (user == "")
            {
                MessageBox.Show("Chưa điền thông tin UserName");
                txbUsername.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        void Check_Status(string user)
        {
            string status = Database.Get_Status(user);

            if (status.Equals("LOCKED") || status.Equals("LOCKED(TIMED)"))
            {
                MessageBox.Show("Tài khoản bị khóa");
            }
            else if (status.Equals("EXEXPIRED(GRACE)"))
            {
                MessageBox.Show("Tài khoản sắp hết hạn");
            }
            else if (status.Equals("EXPIRED & LOCKED(TIMED)"))
            {
                MessageBox.Show("Tài khoản bị khóa do hết hạn");
            }
            else if (status.Equals("EXPIRED"))
            {
                MessageBox.Show("Tài khoản hết hạn");
            }
            else if (status.Equals(" "))
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string sid = txbSid.Text;
            string user = txbUsername.Text;

            if (Check_Textbox(host, port, sid, user))
            {
                Database.Set_Database(host, port, sid, user, "");
                Database.ConnectSys();
                if (Database.Get_Status(user).Equals("OPEN"))
                {
                    OracleConnection c = Database.Get_connectSys();
                    fAuthentication f = new fAuthentication(host, port, sid, user);
                    this.Hide();
                    txbUsername.Clear();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    Check_Status(user);
                    return;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string host = txbHost.Text;
            string port = txbPort.Text;
            string sid = txbSid.Text;

            Database.Set_Database(host, port, sid, "", "");
            Database.ConnectSys();
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
