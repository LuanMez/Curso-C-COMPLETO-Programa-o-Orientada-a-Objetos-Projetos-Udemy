/*Fazer um programa para ler um número inteiro 
e dizer se este número é par ou ímpar.
Exemplos:
Entrada: Saída:
12       PAR

Entrada: Saída:
-27      IMPAR

Entrada: Saída:
0        PAR*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeercicio02IfElse {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero inteiro");
            int numero = int.Parse(Console.ReadLine());

            int resultado = parOuImpar(numero);

            switch (resultado) {
                case 0:
                    Console.WriteLine("IMPAR");
                    break;
                case 1:
                    Console.WriteLine("PAR");
                    break;
            }
        }

        static int parOuImpar(int numero) {
            if (numero % 2 == 0) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}
