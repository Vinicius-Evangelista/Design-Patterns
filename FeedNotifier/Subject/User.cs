using FeedNotifier.Observer;
using FeedNotifier.UserActions;

namespace FeedNotifier.Subject;

// Observer
// Subject
public class User : IFollower
{
    private readonly List<IFollower> followers = new();

    private readonly INotifier _notifier;

    private readonly List<Post> feeds = new();
    public string Username { get; set; }

    public User(INotifier notifier, string userName)
    {
        _notifier = notifier;
        Username = userName;
    }

    public void Post(string messasge)
    {
        var post = new Post(user: Username, messasge);
        feeds.Add(post);

        Notify(post.Action);
    }

    public void Like()
    {
        var like = new Like(user: Username);
        Notify(like.Action);
    }

    public void Comment(string message)
    {
        var comment = new Comment(user: Username, message: message);
        Notify(comment.Action);
    }

    public void AddFollower(User user)
    {
        followers.Add(user);
    }

    public void Notify(UserActionType action)
        => _notifier.Notify(followers, action, Username);
}
