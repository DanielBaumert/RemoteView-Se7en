using Se7en.Net;
using Se7en.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktop
{
    public partial class RemoteView : WinFrom
    {
        private TcpIpClient _client;
        public RemoteView(TcpIpClient client) {
            InitializeComponent();
            _client = client;
            _client.ClientDisconnected += Client_ClientDisconnected;
        }

        private void Client_ClientDisconnected(TcpIpClient arg1) {
            MessageBox.Show("Connection lost or the host closed the connection");
            Close();
        }
    }
}
