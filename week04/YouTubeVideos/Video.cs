using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Transactions;
public class Video
{
    public string Title;
    public string Author;
    public int Length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetCommments()
    {
        return _comments;
    }
}

