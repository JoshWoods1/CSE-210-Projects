public class Comment
{
    public string _commenterName;
    public string _commentText;

    public Comment(string commenter, string text)
    {
        _commenterName = commenter;
        _commentText = text;
    }

     public override string ToString()
    {
        return $"{_commenterName} - {_commentText}";
    }
}