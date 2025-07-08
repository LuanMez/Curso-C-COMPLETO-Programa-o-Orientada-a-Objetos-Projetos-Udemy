/*Você deve fazer um programa que leia um valor qualquer 
e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este 
valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 0 e 100");
            float num = float.Parse(Console.ReadLine());

            if (num < 0.0 || num > 100.0) {
                Console.WriteLine("Fora de intervalo");
            } else if (num >= 0 && 25 >= num) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (50 >= num) {
                Console.WriteLine("Intervalo [25,50]");
            } else if (75 >= num) {
                Console.WriteLine("Intervalo [50,75]");
            } else {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
