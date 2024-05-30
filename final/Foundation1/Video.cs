using System;
using System.IO;

public class Video
{
    private string _videoAuthor;
    private string _videoTitle;
    private int _videoLength;
    private List<Comment> _comments;

    public Video()
    {

    }

    public Video(string videoAuthor, string videoTitle, int videoLength, List<Comment> comments)
    {
        _videoAuthor = videoAuthor;
        _videoTitle = videoTitle;
        _videoLength = videoLength;
        _comments = comments;
    }

    public void SetVideoAuthor(string videoAuthor)
    {
        _videoAuthor = videoAuthor;
    }

    public string GetVideoAuthor()
    {
        return _videoAuthor;
    }

    public void SetVideoTitle(string videoTitle)
    {
        _videoTitle = videoTitle;
    }

    public string GetVideoTitle()
    {
        return _videoTitle;
    }


    public void SetVideoLength(int videoLength)
    {
        _videoLength = videoLength;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }


    public int GetCommentNumber()
    {
        return _comments.Count();
    }

    public void DisplayAll(List<Comment> comments, Video video)
    {         
        
        Console.WriteLine($"Author: {video.GetVideoAuthor()}\nTitle: {video.GetVideoTitle()}\nLength(seconds): {video.GetVideoLength()}");
        Console.WriteLine($"Total number of Comments: {video.GetCommentNumber()} ");

        Console.WriteLine("Comment details: ");
        for (int i = 0; i < comments.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {comments[i].GetComment()}");
        }

        Console.WriteLine();
    }
    

}