using System;

class Program
{
    static void Main(string[] args)
    {
        // Add information into an object of video 1.
        List<Comment> v1Comments = new List<Comment>();

        Comment v1Comments1 = new Comment("John", "This was my favorite hymn!");
        v1Comments.Add(v1Comments1);

        Comment v1Comments2 = new Comment("Amy", "This hymn calms my anxiety so much.");
        v1Comments.Add(v1Comments2);

        Comment v1Comments3 = new Comment("Mark", "Is it normal to tear up after listening to this?");
        v1Comments.Add(v1Comments3);

        Video video1 = new Video("The Piano Guys", "The Mission / How Great Thou Art", 218, v1Comments);

        
        // Add information into an object of video 2.
        List<Comment> v2Comments = new List<Comment>();

        Comment v2Comments1 = new Comment("Juju", "This is my favorite nursery song.");
        v2Comments.Add(v2Comments1);

        Comment v2Comments2 = new Comment("User-xz", "Of all the Child's Prayer songs this one is my favorite.");
        v2Comments.Add(v2Comments2);

        Comment v2Comments3 = new Comment("TIQ", "My son's favorite song. He passed away in 2007 and this song was our theme song.");
        v2Comments.Add(v2Comments3);

        Video video2 = new Video("Peggy Olson", "A Child's Prayer", 142, v2Comments);

        
        // Add information into an object of video 3.

        List<Comment> v3Comments = new List<Comment>();

        Comment v3Comments1 = new Comment("Gideon", "Love this song!");
        v3Comments.Add(v2Comments1);

        Comment v3Comments2 = new Comment("Leanne", "So nice song.");
        v3Comments.Add(v2Comments2);

        Comment v3Comments3 = new Comment("3072", "I remember that I sang this song when I was 7.");
        v3Comments.Add(v2Comments3);

        Video video3 = new Video("Shawna Edwards", "I Will Shine", 195, v3Comments);

        // Create a new List<Video> to save three videos.
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        for (int i = 0; i < videos.Count(); i ++)
        {
            Console.WriteLine($"{videos[i]}{i+1} details: ");
            videos[i].DisplayAll(videos[i].GetComments(), videos[i]);
        }

    }
}