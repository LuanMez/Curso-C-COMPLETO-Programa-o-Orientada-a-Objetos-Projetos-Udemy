/*Leia 2 valores inteiros (A e B). Após, o programa 
deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos 
entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03IfElse
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Digite o primeiro numero inteiro");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero inteiro");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = verificarMultiplo(num1, num2);

            switch (resultado) {
                case 0:
                    Console.WriteLine("SAO MULTIPLOS");
                    break;
                case 1:
                    Console.WriteLine("NAO SAO MULTIPLOS");
                    break;
            }
        }

        static int verificarMultiplo(int num1, int num2) {
            if (num1 % num2 == 0 || num2 % num1 == 0) {
                return 0;
            } else {
                return 1;
            }
        }
    }
}
