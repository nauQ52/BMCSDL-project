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

namespace DOAN
{
    public partial class fAuthPublicKey : Form
    {
        private string host;
        private string port;
        private string sid;
        private string username;
        public fAuthPublicKey(string Host, string Port, string Sid, string Username)
        {
            username = Username;
            host = Host;
            port = Port;
            sid = Sid;
            InitializeComponent();
        }
    }
}
