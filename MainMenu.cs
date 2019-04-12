using RemoteDesktop.Net;
using static RemoteDesktop.Net.ConnectionMessages;

using Se7en.Net;
using Se7en.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktop
{
    public partial class MainMenu : WinFrom
    {
        private const int DEFAULT_PORT = 8008;
        private Server _server;
        public MainMenu() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            _server = new Server();
            _server.ClientConnected += Server_ClientConnected;
            LbHostname.Text = Environment.MachineName;
            TbServerPort.CueText = DEFAULT_PORT.ToString();
            SetupServer();
        }


        private void Server_ClientConnected(TcpIpClient arg1) {
            if(MessageBox.Show("Accept Client?", "RemoteConnection", MessageBoxButtons.YesNo) == DialogResult.No) {
                arg1.Disconnect();
            } else {
                arg1.SendMessage(ALLOW_CONNECTION);
            }
        }

        private void BtSetServerPort_Click(object sender, EventArgs e) => SetupServer();
        private void SetupServer() {
            TbbServerStatus.ToggleState = false;
            _server.Stop();
            if (TbServerPort.IsMatch || string.IsNullOrEmpty(TbServerPort.Text)) {
                if (string.IsNullOrEmpty(TbServerPort.Text)) {
                    StartServer(DEFAULT_PORT);
                } else {
                    if (int.TryParse(TbServerPort.Text, out int port)) {
                        StartServer(port);
                    }
                }
            }
        }

        private void StartServer(int port) {
            try {
                _server.Start(IPAddress.Any, port);
                TbbServerStatus.ToggleState = true;
            } catch {
                MessageBox.Show("Something went wrong with port");
            }
        }

        private void BtConnectToClient_Click(object sender, EventArgs e) {
            if (TbRemotePort.IsMatch) {
                if (int.TryParse(TbRemotePort.Text, out int port)) {
                    string hostName = TbRemoteHost.Text;
                    TcpIpClient client = new TcpIpClient();
                    
                    if (client.Connect(hostName, port)) {
                        client.ResiveMessage += Client_ResiveMessage;
                    } else {
                        MessageBox.Show("Unable to reach the host");
                    }
                } else {
                    MessageBox.Show("Some error is thrown");
                }
            } else {
                MessageBox.Show("Invalide port binding");
            }
        }

        private void Client_ResiveMessage(TcpIpClient arg1, string arg2) {
            switch (arg2) {
                case ALLOW_CONNECTION:
                    RemoteView view = new RemoteView(arg1);
                    view.Show();
                    break;
                default:
                    break;
            }
        }


        private string CharToString(char x) => x.ToString();
    }
}
