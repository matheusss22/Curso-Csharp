using System;
using Workspace.Entities;

namespace Workspace
{
    public class Program
    {
        public static void Main()
        {
            Comment c1 = new Comment(text: "Have a nice trip");
            Comment c2 = new Comment(text: "Wow that's awesome!");

            Post p1 = new Post(
                moment: DateTime.Parse("21/06/2018 13:05:44"),
                title: "Traveling to New Zealand",
                content: "I'm going to visit this wonderful contry!",
                likes: 12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment(text: "Good nigth");
            Comment c4 = new Comment(text: "May the Force be with you");

            Post p2 = new Post(
                moment: DateTime.Parse("28/07/2018 23:14:19"),
                title: "Good night guys",
                content: "See you tomorrow",
                likes: 5
            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
