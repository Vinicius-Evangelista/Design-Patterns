using FeedNotifier.Notification;
using FeedNotifier.UserActions;

namespace FeedNotifier.Observer;

// Observer
public class Notifier : INotifier
{
    public void Notify(List<IFollower> followers, UserActionType actionType, string userName)
    {
        var notification = NotificationFactory.CreateNotification(actionType, userName);
        
        foreach (var follower in followers)
        {
            Console.WriteLine($"Hey {follower.Username}");
            Console.WriteLine(notification.Message);
        }
    }
}
