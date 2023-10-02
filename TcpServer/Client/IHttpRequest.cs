public interface IHttpRequest
{
    public void ProcessRequest();

    public void SendResponse();

    public void SendError();
    
    public void ReadPayload();
}