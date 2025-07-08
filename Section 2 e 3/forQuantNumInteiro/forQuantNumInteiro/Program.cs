using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forQuantNumInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma = 0;

            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++) { //em c# tem que declarar no for
                int valor;
                Console.WriteLine("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());
                soma += valor;
                Console.WriteLine("Valor #{0} {1}",i ,valor);
            }
            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
