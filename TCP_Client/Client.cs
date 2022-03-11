using System.Net.Sockets;
using System.Text;

namespace TCP_Client
{
    public class Client
    {
        private static void Main()
        {
            TcpClient tcpClient = new TcpClient("localhost", 9090);
            StringBuilder buffer = new StringBuilder();


            while (true)
            {
                Console.WriteLine("Введите свое сообщение:");

                buffer.Clear();
                buffer.Append(Console.ReadLine());

                tcpClient.GetStream().Write(Encoding.ASCII.GetBytes(buffer.ToString()));
                
            }

            tcpClient.Close();
        }
    }
}