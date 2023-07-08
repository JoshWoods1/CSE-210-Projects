public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        ToString();
        Console.WriteLine();

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }
        Console.WriteLine();
    }
}