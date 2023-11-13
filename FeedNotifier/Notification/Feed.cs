namespace FeedNotifier.Notification;

public class Feed : NotificationBase
{
    public string? Photo { get; init; }

    public Feed(string user, string message) : base(user, $"{user} has a new post!")
    {
    }
}
