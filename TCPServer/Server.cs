using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ModelLibrary;

namespace TCPServer
{
    class Server
    {
        private readonly int _port;
        private static double _value = 0;

        public Server(int port)
        {
            this._port = port;
        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, _port);
            serverListener.Start();

            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSockect = socket;
                    DoClient(tempSockect);
                });
            }
        }

        private static void DoClient(TcpClient socket)
        {
            // Kører hele tiden
            while (true)
            {
                StreamReader sr = new StreamReader(socket.GetStream());
                StreamWriter sw = new StreamWriter(socket.GetStream());

                string srText = sr.ReadLine();
                string srValue = Regex.Match(srText, @"\d+").Value;
                double value;

                value = Convert.ToDouble(srValue);

                if (srText.Contains("ToGram"))
                {
                    _value = Converter.OuncesToGram(value);
                    
                }
                else if (srText.Contains("ToOunce"))
                {
                    _value = Converter.GramToOunces(value);
                }
                else
                {
                    _value = 0;
                }
                Console.WriteLine($"{_value.ToString()}");

            }

            // Lukker efter reguest
            //using (StreamReader sr = new StreamReader(socket.GetStream()))
            //using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            //{
            //    string srText = sr.ReadLine();
            //    string srValue = Regex.Match(srText, @"\d+").Value;
            //    double value;

            //    value = Convert.ToDouble(srValue);

            //    if (srText.Contains("ToGram"))
            //    {
            //        _value = Converter.OuncesToGram(value);
                    
            //    }
            //    if (srText.Contains("ToOunce"))
            //    {
            //        _value = Converter.GramToOunces(value);
            //    }
            //    Console.WriteLine($"{_value.ToString()}");
            //}
            //socket.Close();
        }
    }
}
