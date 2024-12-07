

public class Video
{
    private string _title;
    private string _authorName;
    private int _duration;
    private List <Comment> _comments;

    public Video (string title, string authorName, int duration, List<Comment> comment)
    {
        _title = title;
        _authorName = authorName;
        _duration = duration;
        _comments = comment;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public int GetNumComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_authorName}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");
        Console.WriteLine("Comments:");
        Console.WriteLine("----------------------------");
        DisplayComments();
        Console.WriteLine("----------------------------");
        Console.WriteLine();

    }
}