using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeKind {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine("---------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine("---------------------------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            DateTime x1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime x2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x1 Kind: " + x1.Kind);
            Console.WriteLine("x1 to Local: " + x1.ToLocalTime());
            Console.WriteLine("x1 to Utc: " + x1.ToUniversalTime());
            Console.WriteLine("---------------------------");
            Console.WriteLine("x2: " + x2);
            Console.WriteLine("x2 Kind: " + x2.Kind);
            Console.WriteLine("x2 to Local: " + x2.ToLocalTime());
            Console.WriteLine("x2 to Utc: " + x2.ToUniversalTime());
            Console.WriteLine("_--------------------------"); 
            Console.WriteLine(x2.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado errado
            Console.WriteLine(x2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}