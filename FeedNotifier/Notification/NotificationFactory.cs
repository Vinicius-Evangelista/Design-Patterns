using FeedNotifier.UserActions;

namespace FeedNotifier.Notification;

public abstract class NotificationFactory
{
    public NotificationFactory(UserActionType action, string message, string user)
    {
        CreateNotification(action, message, user);
    }

    public static NotificationBase CreateNotification(UserActionType action, string user, string message = "")
    {
        switch (action)
        {
            case UserActionType.Like :
                return new Like(user, message);
            case UserActionType.Comment:
                return new Comment(user, message);
            case UserActionType.Feed:
                return new Feed(user, message);
            default:
                throw new ArgumentException("InvalidOption");
        }
    }
}
