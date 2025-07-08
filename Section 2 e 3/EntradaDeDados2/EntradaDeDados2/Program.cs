using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            char y = char.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3]);

            Console.WriteLine("{0}\n{1}\n{2}\n{3} {4} {5} {6}", x, y, z, nome, sexo, idade, altura);
        }
    }
}
