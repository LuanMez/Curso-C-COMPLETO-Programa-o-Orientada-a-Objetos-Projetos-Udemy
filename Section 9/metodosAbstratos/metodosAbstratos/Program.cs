using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metodosAbstratos.Entities;
using metodosAbstratos.Entities.Enums;

namespace metodosAbstratos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of shpaes: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Shape> list = new List<Shape>();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char c = char.Parse(Console.ReadLine()!);
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine()!);

                if(c == 'r' || c == 'R') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine()!);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine()!);
                    list.Add(new Rectangle(width, height, color));
                } else if (c == 'c' || c == 'C') {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine()!);
                    list.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine("\nSHAPE AREAS: ");
            foreach (var x in list) {
                Console.WriteLine(x.Area().ToString("F2"));
            }
        }
    }
}