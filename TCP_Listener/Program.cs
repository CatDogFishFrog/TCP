using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCP_Listener
{
    public class Programm
    {
        static void Main()
        {
            TcpListener tcp = new TcpListener(IPAddress.Parse("0.0.0.0"), 9090);
            tcp.Start(32);

            byte[] buffer = new byte[64];

            using TcpClient tcpClient = tcp.AcceptTcpClient();
            tcpClient.GetStream().Read(buffer, 0, buffer.Length);

            string data = Encoding.ASCII.GetString(buffer);
            Console.WriteLine(data);

            tcp.Stop();

        }
    }
}