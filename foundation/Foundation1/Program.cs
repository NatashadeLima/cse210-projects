
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Exploring the Ocean", "John Doe", 540);
        video1.AddComment(new Comment("Alice", "This is amazing!"));
        video1.AddComment(new Comment("Bob", "I love ocean documentaries."));
        video1.AddComment(new Comment("Charlie", "Fascinating video, thanks for sharing!"));

        Video video2 = new Video("Cooking 101", "Jane Smith", 720);
        video2.AddComment(new Comment("Dave", "This recipe looks delicious."));
        video2.AddComment(new Comment("Ella", "I tried it, and it turned out great!"));
        video2.AddComment(new Comment("Frank", "Very helpful tips, thank you."));

        Video video3 = new Video("Tech Reviews", "Mark Lee", 300);
        video3.AddComment(new Comment("George", "Informative and concise."));
        video3.AddComment(new Comment("Hannah", "I’m planning to buy this product now."));
        video3.AddComment(new Comment("Ivy", "Could you review more gadgets?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information about each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}