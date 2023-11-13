namespace FeedNotifier.Notification;

public class Like : NotificationBase
{
    public int Likes { get; init; }

    public Like(string user, string message) : base(user, $"{user} gave you a like!")
    {
    }
}
