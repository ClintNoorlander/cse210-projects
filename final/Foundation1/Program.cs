using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some example videos and comments
        Video v1 = new Video
        {
            Title = "C# Programming Basics",
            Author = "John Doe",
            LengthSeconds = 1800,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Alice", CommentText = "Great tutorial!"},
                new Comment { CommenterName = "Bob", CommentText = "Thanks for the clear explanations."},
                new Comment { CommenterName = "Charlie", CommentText = "I've been looking for a resource like this for a while."}
            }
        };

        Video v2 = new Video
        {
            Title = "Introduction to ASP.NET Core",
            Author = "Jane Smith",
            LengthSeconds = 2400,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "David", CommentText = "Very helpful, thanks!"},
                new Comment { CommenterName = "Emily", CommentText = "I'm excited to start building my own web apps now."},
                new Comment { CommenterName = "Frank", CommentText = "This is a great starting point."}
            }
        };

        // Add videos to a list
        List<Video> videos = new List<Video> { v1, v2 };

        // Display information about each video
        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length (seconds): " + v.LengthSeconds);
            Console.WriteLine("Number of comments: " + v.GetNumComments());

            Console.WriteLine("Comments:");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine("- " + c.CommenterName + ": " + c.CommentText);
            }

            Console.WriteLine();
        }
    }
}
