/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro positivo");
            int num = int.Parse(Console.ReadLine());
            int fora = 0, dentro = 0, verificar = 0;

            for(int i = 1; i <= num; i++) {
                Console.WriteLine("Digite um numero no intervado de [10,20]");
                verificar = int.Parse(Console.ReadLine());
                if(verificar > 20 || verificar < 10) {
                    fora++;
                } else {
                    dentro++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
