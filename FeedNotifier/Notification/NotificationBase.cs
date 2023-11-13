namespace FeedNotifier.Notification;

public class NotificationBase
{
    public string User { get; set; }

    public string Message { get; set; }

    public NotificationBase(string user, string message)
    {
        User = user;
        Message = message;
    }
}
