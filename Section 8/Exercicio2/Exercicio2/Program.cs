﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio2.Entities;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 12);
            p2.addComment(c3);
            p2.addComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}