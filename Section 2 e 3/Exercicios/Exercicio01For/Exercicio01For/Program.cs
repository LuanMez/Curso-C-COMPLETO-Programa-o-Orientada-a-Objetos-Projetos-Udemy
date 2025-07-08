/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre 
os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 1 eh 1000");
            int numero = int.Parse(Console.ReadLine());

            while(numero < 1 || numero > 1000) {
                Console.WriteLine("Digite novamente um numero entre 1 eh 1000");
                numero = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= numero; i+=2) {
                if(i <= numero) {
                    Console.WriteLine(i);
                }
            }

            /*for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }*/
        }
    }
}
