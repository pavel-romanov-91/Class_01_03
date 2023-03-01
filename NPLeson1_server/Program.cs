using System.Net;
using System.Net.Sockets;

namespace NPLeson1_server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);
            socket.Bind(point);
            socket.Listen(1000);
        }
    }
}