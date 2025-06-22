using DOAN.F_AUTH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DOAN
{
    public partial class fAuthentication : Form
    {
        private string host;
        private string port;
        private string sid;
        private string username;
        public fAuthentication(string Host, string Port, string Sid, string Username)
        {
            username = Username;
            host = Host;
            port = Port;
            sid = Sid;
            InitializeComponent();
        }

        private void btnAuthChallengeRes_Click(object sender, EventArgs e)
        {

            this.Hide();
            fAuthChallengeRes f = new fAuthChallengeRes(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }

        private void btnAuthSym_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAuthSym f = new fAuthSym(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }

        private void btnAuthPublicKey_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAuthPublicKey f = new fAuthPublicKey(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }

        private void btnAuthHash_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAuthHash f = new fAuthHash(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }

        private void btnAuthFace_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAuthFace f = new fAuthFace(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAuthSimple f = new fAuthSimple(host, port, sid, username);
            f.ShowDialog();
            this.Show();
        }
    }
}
