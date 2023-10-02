namespace TcpServer.Adaptee;

internal class Http2 : IHttp2
{
    public string Method { get; set; }

    public string Scheme { get; set; }

    public string Authority { get; set; }

    public string Path { get; set; }

    public string UserAgent { get; set; }

    public Dictionary<string, string> CustomHeaders { get; set; } = new Dictionary<string, string>();

    public Uri RequestUri { get; set; }

    public HttpContent Content { get; set; }

    public void ProcessConnections()
    {
        Console.WriteLine("Processing Connections.");
    }

    public void ReadPackets()
    {
        Console.WriteLine("Reading Packets.");
    }

    public void RequestLostPacktes()
    {
        Console.WriteLine("Requesting Lost Packets.");
    }

    public void SendError()
    {
        Console.WriteLine("Sending Error.");
    }

    public void SendResponse()
    {
        Console.WriteLine("Sending response.");
    }
}
