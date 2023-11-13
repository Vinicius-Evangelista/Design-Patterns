using FeedNotifier.Notification;

namespace FeedNotifier.UserActions;

public abstract class UserAction
{
    public string Message { get; set; }

    public Guid UserId { get; set; }

    public string UserName { get; set; }

    public UserActionType Action { get; init; }

    public UserAction(string username, UserActionType userActionType)
    {
        UserId = Guid.NewGuid();
        UserName = username;
        Action = userActionType;
    }
}
