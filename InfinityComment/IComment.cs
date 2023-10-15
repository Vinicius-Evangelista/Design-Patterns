namespace InfinityComment;

public interface IComment
{
    void AddComment(IComment comment);

    void ListComments(int hifenInterval);

    void EditComment(IComment comment);

    void DeleteComment(IComment comment);
}