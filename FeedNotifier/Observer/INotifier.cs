using FeedNotifier.Subject;
using FeedNotifier.UserActions;

namespace FeedNotifier.Observer;

public interface INotifier
{
    public void Notify(List<IFollower> followers, UserActionType actionType, string userName);
}
