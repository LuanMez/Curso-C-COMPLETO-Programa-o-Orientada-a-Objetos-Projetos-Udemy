using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;
            double n5 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);


            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Calculo de baskara");
            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double resultado1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double resultado2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            /*Math.Pow(x, y), calcula um número elevado a uma potência, x o numero, y a potencia
            Math.Sqrt(z), calcula a raiz quadrada de um número, no caso z*/

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            CrossAppDomainDelegate
        }
    }
}
