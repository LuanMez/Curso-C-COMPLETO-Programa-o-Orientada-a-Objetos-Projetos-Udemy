using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu produto");


            double preco= double.Parse(Console.ReadLine());
            double desconto;

            if(preco > 100.0) {
                desconto = preco - (preco * 0.1); //preco com o desconto de 10%
            } else {
                desconto = preco; //preco sem desconto
            }

                Console.WriteLine($"Seu preco final {desconto}");
        }
    }
}
