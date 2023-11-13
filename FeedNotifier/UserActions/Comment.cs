namespace FeedNotifier.UserActions;

public class Comment : UserAction
{
    public string Message { get; set; }
    public Comment(string user, string message) : base(user, UserActionType.Comment)
    {
        Message = message;
    }
}
