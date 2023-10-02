using System.Net.NetworkInformation;

namespace TcpServer.Target;
public class Http1 : IHttpRequest
{
    public List<string> Headers { get; set; }

    public TcpState MyProperty { get; set; }

    public string Payload { get; set; }

    public int Version { get; set; }

    public void ProcessRequest()
    {
        Console.WriteLine("Processing");
        Console.WriteLine("Processed");
    }

    public void ReadPayload()
    {
        Console.WriteLine("Reading");
        Console.WriteLine("Readed");
    }

    public void SendError()
    {
        Console.WriteLine("Sending");
        Console.WriteLine("Sended");
    }

    public void SendResponse()
    {
        Console.WriteLine("Sending");
        Console.WriteLine("Sended");
    }
}
