using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressãoCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine());
            //expressão condicional
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            /*if (preco < 20.0) {
                desconto = preco * 0.1;
            } else {
                desconto = preco * 0.05
            }*/

                Console.WriteLine(desconto);

        }
    }
}
