using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private double _lengthInSeconds;

    private List<Comment> _comments;

    public Video(string title, string author, double lengthInSenconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSenconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}