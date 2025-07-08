using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostrarTresNumeroOMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres números");
            Console.WriteLine("Digite o primeiro numero");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            int z = int.Parse(Console.ReadLine());

            int resultado = verificarMaior(x, y, z);

            //int resultado = verificarMaior(4, 6, 2); pode tbm declarar assim mas ne

            Console.WriteLine("O maior número que voce digitou foi {0}", resultado);
        }

        static int verificarMaior (int x, int y, int z) {
            int maior;

            if(x > y && x > z) {
                maior = x;
            } else if (y > z) {
                maior = y;
            } else {
                maior = z;
            }

            return maior;
        }
    }
}
