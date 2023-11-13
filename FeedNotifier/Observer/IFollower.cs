using FeedNotifier.Subject;
using FeedNotifier.UserActions;

namespace FeedNotifier.Observer;

public interface IFollower
{
    public string Username { get; set; }
    public void Notify(UserActionType actionType);
}
