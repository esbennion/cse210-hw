using System;
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)

    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to Make Cookies", "Emily Bennion", 525);
        v1.AddComment(new Comment("Natasha", "These look amazing!"));
        v1.AddComment(new Comment("Josh", "I need to try this recipe."));
        v1.AddComment(new Comment("Natalie", "My cookies never look that good, what is the secret??"));
        v1.AddComment(new Comment("Jean", "These look like my grandmothers cookies."));
        videos.Add(v1);

        Video v2 = new Video("How to win GO FISH every time!", "Game Expert", 350);
        v2.AddComment(new Comment("Tom", "This is almost to easy."));
        v2.AddComment(new Comment("Kyle", "This is how I played growing up and it was fun!"));
        v2.AddComment(new Comment("Savanna", "I always win with this trick!"));
        videos.Add(v2);

        Video v3 = new Video("Where is Waldo?", "Hide and Seek", 780);
        v3.AddComment(new Comment("Spencer", "No one would every think to look in there.."));
        v3.AddComment(new Comment("Jacob", "Where did Waldo even come from?"));
        v3.AddComment(new Comment("Anne", "My Dad's name is Waldo and you could always find him in an arcade."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments: ");

        foreach (Comment com in video.GetCommments())
            {
                Console.WriteLine($"{com.Name}: {com.Text}");
            }
            Console.WriteLine();

        }
    }
}

