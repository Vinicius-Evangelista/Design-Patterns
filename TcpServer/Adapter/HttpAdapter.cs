using TcpServer.Adaptee;

namespace TcpServer.Adapter;

public class HttpAdapter : IHttpRequest
{
    private readonly IHttp2 http2;

    public HttpAdapter(IHttp2 http2)
    {
        this.http2 = http2;
    }

    public void ProcessRequest()
    {
        http2.ReadPackets();
    }

    public void ReadPayload()
    {
        http2.ReadPackets();
    }

    public void SendError()
    {
        http2.SendError();
    }

    public void SendResponse()
    {
        http2.SendResponse();
    }
}
