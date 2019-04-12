using Se7en.Net;
using System.Collections.Generic;

namespace RemoteDesktop.Net
{
    class Server : TcpIpServer
    {
        public Server() {
        }

        public override bool AccessRequest(TcpIpClient client) {
            return true;
        }

        public override void ClienMessageResieve(TcpIpClient client, string message) {
            switch (message) {
                default:
                    break;
            }
        }

        public override void ClientDisconnected(TcpIpClient client) {
            
        }
    }
}
