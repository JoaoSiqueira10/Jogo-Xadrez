using System;
using Exercicio9_2_StringBuilder;
using Exercicio9_2_StringBuilder.Entities;

namespace Exercicio9_2_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow tah's awesomw!");

            Post p1 = new Post(
                DateTime.Parse("06/21/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("07/28/2018 23:14:19"),
                "Good night",
                "See you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
