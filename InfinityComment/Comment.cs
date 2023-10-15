using System.Collections;

namespace InfinityComment;

// Component
public class Comment : IComment, IEnumerable<IComment>
{
    // Childrens
    private readonly List<IComment> comments = new ();

    public string Text { get; set; }

    public Comment(string comment)
    {
        Text = comment;
    }

    public void AddComment(IComment comment) => 
        comments.Add(comment);


    public void DeleteComment(IComment comment) =>
        comments.Remove(comment);
    
    public void EditComment(IComment comment) => 
        throw new NotImplementedException();

    public void ListComments(int hifenInterval)
    {
        Console.WriteLine(new string('-', hifenInterval) + Text);

        foreach(var comment in comments)
        {
            comment.ListComments(hifenInterval * 2);
        }
    }
            
    public IEnumerator<IComment> GetEnumerator()
    {
        return comments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return comments.GetEnumerator();
    }
}
