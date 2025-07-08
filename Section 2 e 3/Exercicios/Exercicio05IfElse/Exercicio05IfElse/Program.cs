/*Com base na tabela abaixo, escreva um programa que leia 
o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o qauntidade que deseja: ");
            int quant = int.Parse(Console.ReadLine());
            double total = 0; ;

            switch (codigo) {
                case 1:
                    total = 4.0 * quant;
                    break;
                case 2:
                    total = 4.50 * quant;
                    break;
                case 3:
                    total = 5.0 * quant;
                    break;
                case 4:
                    total = 2.0 * quant;
                    break;
                case 5:
                    total = 1.0 * quant;
                    break;
            }

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}
