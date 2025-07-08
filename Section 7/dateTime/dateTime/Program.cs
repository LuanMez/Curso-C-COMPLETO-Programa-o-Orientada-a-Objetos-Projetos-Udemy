using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2025, 5, 11); //cria uma nova data
            DateTime d2 = new DateTime(2025, 5, 11, 17, 55, 4); //cria uma nova data e hora
            DateTime d3 = DateTime.Now; //DateTime.Now pega a data e hora atual do sistema
            DateTime d4 = DateTime.Today; //data de hoje e horario zeradoi
            DateTime d5 = DateTime.UtcNow; //data atual no greenwich


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-05-18");
            DateTime d7 = DateTime.Parse("2000-05-18 15:34:45");

            DateTime d8 = DateTime.Parse("12/09/2023");
            DateTime d9 = DateTime.Parse("12/09/2023 18:29:09");

            Console.WriteLine("------------------------------------");
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("2022-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------------");
            Console.WriteLine(d10);
            Console.WriteLine(d11);
        }
    }
}
