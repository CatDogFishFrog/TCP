using System.Net.Sockets;
using System.Text;

namespace TCP_Client
{
    public class Program
    {
        private static void Main()
        {
            TcpClient tcpClient = new TcpClient("localhost", 9090);


            tcpClient.GetStream().Write(Encoding.ASCII.GetBytes("Hello TCP listener!"));

            tcpClient.Close();
        }
    }
}