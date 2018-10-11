using System;

namespace TCPServer
{
    class Program
    {
        private const int Port = 10001;

        static void Main(string[] args)
        {
            Server server = new Server(Port);
            server.Start();

            Console.ReadLine();
        }
    }
}
