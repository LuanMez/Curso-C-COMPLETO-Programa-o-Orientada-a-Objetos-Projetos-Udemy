/*Fazer um programa para ler um número N. Depois leia 
 * N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem 
"divisao impossivel".*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de elementos para serem lidos: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) {
                Console.WriteLine("Digite o valor 1: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor 2: ");
                double valor2 = double.Parse(Console.ReadLine());

                if (valor2 != 0) {
                    double resultado = valor1 / valor2;
                    Console.WriteLine("{0:F1}", resultado);
                } else {
                    Console.WriteLine("Divisão impossivel");
                }
            }
        }
    }
}
