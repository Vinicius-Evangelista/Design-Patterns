namespace TcpServer.Adaptee;

public interface IHttp2
{
    public void ProcessConnections();

    public void RequestLostPacktes();
    
    public void ReadPackets();

    public void SendError();

    public void SendResponse();
}
