using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioNumeroNegativo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            int resultado = verificarInteiro(x);

            switch (resultado) {
                case -1:
                    Console.WriteLine("O número que digitou é negativo");
                    break;
                case 0:
                    Console.WriteLine("O número que digitou é 0");
                    break;
                case 1:
                    Console.WriteLine("O número que digitou é positivo");
                    break;
            }
        }

        static int verificarInteiro(int x) {
            if(x > 0) {
                return 1;
            } else if (x == 0) {
                return 0;
            } else {
                return -1;
            }
        }
    }
}
