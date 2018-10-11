using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Client
    {
        private readonly int _port;

        public Client(int port)
        {
            this._port = port;
        }

        public void Start()
        {
            using (TcpClient clientSocket = new TcpClient("localhost", _port))
            using (StreamWriter sw = new StreamWriter(clientSocket.GetStream()))
            {
                string toGram = "2 ToGram";
                string toOunce = "2 ToOunce";

                sw.WriteLine(toOunce.ToString());
                sw.Flush();
            }
            ;
        }
    }
}
