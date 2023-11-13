namespace FeedNotifier.UserActions;

public class Like : UserAction
{
    public int Likes { get; init; }

    public Like(string user) : base(user, UserActionType.Like)
    {
    }
}
