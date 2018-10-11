using System;

namespace TCPClient
{
    class Program
    {
        private const int Port = 10001;

        static void Main(string[] args)
        {
            Client server = new Client(Port);
            server.Start();

            Console.ReadLine();
        }
    }
}
