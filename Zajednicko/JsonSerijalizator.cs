using System.Net.Sockets;
using System.Text.Json;

namespace Zajednicko
{
    public class JsonSerijalizator
    {
        private Socket socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonSerijalizator(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
        }

        public void Send(object obj)
        {
            writer.WriteLine(JsonSerializer.Serialize(obj));
        }

        public T Receive<T>()
        {
            string json = reader.ReadLine();
            return JsonSerializer.Deserialize<T>(json);
        }

        public T ReadType<T>(object obj)
        {
            return JsonSerializer.Deserialize<T>((JsonElement)obj);
        }

        public void Close()
        {
            stream.Close();
            reader.Close();
            writer.Close();
        }
    }
}
