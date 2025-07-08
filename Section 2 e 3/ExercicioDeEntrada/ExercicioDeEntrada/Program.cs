using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeEntrada {
    class Program {
        static void Main(string[] args) {

            string nome = Console.ReadLine();
            int quant = int.Parse(Console.ReadLine());
            float preco = float.Parse(Console.ReadLine());

            string[] array = Console.ReadLine().Split(' ');

            string a = array[0];
            int b = int.Parse(array[1]);
            float c = float.Parse(array[2]);

            Console.WriteLine($"{nome}\n{quant}\n{preco}\n{a} {b} {c}");

            //verificando se é par ou impar
            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("O numero que digitou é par");
            }
            else {
                Console.WriteLine("O numero que digitou é impar");
            }
        }
    }
}
