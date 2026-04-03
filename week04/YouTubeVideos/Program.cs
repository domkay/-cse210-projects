using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Life skills", "Don't drink and drive.", 600);
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks."));
        video1.AddComment(new Comment("User3", "Can you explain more?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Living and sharing", "Life Tips", 450);
        video2.AddComment(new Comment("Alice", "I finally understand it."));
        video2.AddComment(new Comment("Bob", "Short and sweet."));
        video2.AddComment(new Comment("Charlie", "Best explanation so far."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Family Values", "Family Matters", 900);
        video3.AddComment(new Comment("Dave", "I love the examples used."));
        video3.AddComment(new Comment("Eve", "Could you do a video on family dynamics?"));
        video3.AddComment(new Comment("Frank", "Subscribed!"));
        videos.Add(video3);

        // Displaying all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
        }
    }
}