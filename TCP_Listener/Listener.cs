using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCP_Listener
{
    public class Listener
    {
        static void Main()
        {
            TcpListener tcp = new TcpListener(IPAddress.Parse("0.0.0.0"), 9090);
            tcp.Start(32);

            byte[] buffer = new byte[512];
            StringBuilder data = new StringBuilder();
            Console.WriteLine("Вывод сообщений:");

            while (true)
            {
                using TcpClient tcpClient = tcp.AcceptTcpClient();
                tcpClient.GetStream().Read(buffer, 0, buffer.Length);

                data.Clear();
                  
                data.Append(Encoding.ASCII.GetString(buffer));

                Console.WriteLine("Клиент: {0}", data);
            }


            //tcp.Stop();

        }
    }
}