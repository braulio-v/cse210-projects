using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Learn C# in 80 Minutes", "Jhon Perez", 4800); 
        Video video2 = new Video("How to be a better Programer", "Jose Smith", 3500);
        Video video3 = new Video("Understanding OOP Concepts and more", "Raul Villa", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial do more please!"));
        video1.AddComment(new Comment("Bob", "Really helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Please make more videos!"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "I love Python and I love you too!"));
        video2.AddComment(new Comment("Kenny", "JavaScript is the best."));
        video2.AddComment(new Comment("Frank", "C++ should be higher on the list."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This made OOP easy to understand."));
        video3.AddComment(new Comment("Henry", "Can you explain more topic next?"));
        video3.AddComment(new Comment("Isabel", "Great examples, very clear."));

        // Store videos in a list 
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

       
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}