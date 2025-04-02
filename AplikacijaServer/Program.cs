using System.Net.Sockets;
using System.Text;
using Zajednicko;

namespace AplikacijaServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                using Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(ServerData.endPoint);
                Console.WriteLine("Сервер је покренут на " + ServerData.endPoint);
                Console.WriteLine("Ослушкивање...\n");

                while (true)
                {
                    serverSocket.Listen();
                    Socket clientSocket = serverSocket.Accept();
                    Console.WriteLine("Клијент повезан");
                    ClientHandler handler = new ClientHandler(clientSocket);
                    Task.Run(() => handler.Handle());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
        }
    }
}
