using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaçõesTimeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan d = new TimeSpan(2, 3, 4, 7, 11);

            Console.WriteLine(d);

            Console.WriteLine("Days: " + d.Days);
            Console.WriteLine("Hours: " + d.Hours);
            Console.WriteLine("Minutes: " + d.Minutes);
            Console.WriteLine("Milliseconds: " + d.Milliseconds);
            Console.WriteLine("Seconds: " + d.Seconds);
            Console.WriteLine("Ticks: " + d.Ticks);

            Console.WriteLine("TotalDays: " + d.TotalDays);
            Console.WriteLine("TotalHours: " + d.TotalHours);
            Console.WriteLine("TotalMinutes: " + d.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + d.TotalSeconds);
            Console.WriteLine("TotalMIlliseconds: " + d.TotalMilliseconds);

            Console.WriteLine("----------------------------");
            //Operações
            TimeSpan x1 = new TimeSpan(1, 30, 10);
            TimeSpan x2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = x1.Add(x2); //somar
            TimeSpan dif = x1.Subtract(x2); //diminuir
            TimeSpan mult = x2.Multiply(2.0); //multiplicar
            TimeSpan div = x2.Divide(2.0); //dividir

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
