using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileNumeroNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis
            double num1 = 1;
            double raizQuadrada;

            while (num1 >= 0) {
                Console.WriteLine("Digite um numero: ");
                num1 = double.Parse(Console.ReadLine());
                raizQuadrada = Math.Sqrt(num1);
                if(num1 >= 0) {
                    Console.WriteLine("A raiz Quadrada de {0} eh {1:F2}", num1, raizQuadrada);
                } else {
                    Console.WriteLine("Numero Negativo!");
                }
            }
        }
    }
}
