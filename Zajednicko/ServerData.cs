using System.Net;

namespace Zajednicko
{
    public static class ServerData
    {
        public static readonly IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
    }
}
