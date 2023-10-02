namespace TcpServer.Client;

public class HttpServer
{
    private readonly IHttpRequest request;

    public HttpServer(IHttpRequest request)
    {
        this.request = request;
    }

    public void ProcessRequest()
    {
        request.ProcessRequest();
    }

    public void ProcessResponse()
    {
        request.SendResponse();
    }

    public void ReadPayload()
    {
        request.ReadPayload();
    }
}