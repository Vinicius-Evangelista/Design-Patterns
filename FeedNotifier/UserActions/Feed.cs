namespace FeedNotifier.UserActions;

public class Post : UserAction
{
    public string? Photo { get; init; }

    public Post(string user, string message) : base(user, UserActionType.Feed)
    {
    }
}
