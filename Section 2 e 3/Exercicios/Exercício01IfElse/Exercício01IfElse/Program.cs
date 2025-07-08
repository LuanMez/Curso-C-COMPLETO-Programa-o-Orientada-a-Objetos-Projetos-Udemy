/*Fazer um programa para ler um número inteiro, e 
 * depois dizer se este número é negativo ou não.
Exemplos:
Entrada: Saída:
-10      NEGATIVO

Entrada: Saída:
8        NAO NEGATIVO

Entrada: Saída:
0        NAO NEGATIVO*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01IfElse
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            int resultado = verificarInteiro(x);

            switch (resultado) {
                case 0:
                    Console.WriteLine("NEGATIVO");
                    break;
                case 1:
                    Console.WriteLine("NAO NEGATIVO");
                    break;
            }
        }

        static int verificarInteiro(int x) {
            if (x >= 0) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}
