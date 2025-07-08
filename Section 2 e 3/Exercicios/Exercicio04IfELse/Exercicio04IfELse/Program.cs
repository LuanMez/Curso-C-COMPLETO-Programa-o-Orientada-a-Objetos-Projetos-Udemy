/*Leia a hora inicial e a hora final de um jogo. 
 A seguir calcule a duração do jogo, sabendo 
 que o mesmo pode começar em um dia e terminar 
 em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04IfELse
{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o primeiro numero inteiro");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero inteiro");
            int num2 = int.Parse(Console.ReadLine());

            int totalHorario = verificarHorario(num1, num2);

            Console.WriteLine("O JOGO DUROU " + totalHorario + " HORA(S)");
        }

        static int verificarHorario(int num1, int num2) {
            int cont = 0;
            if(num1 == num2) {
                return 24;
            } else {
                while (num1 != num2) {
                    if (num1 == 24) {
                        num1 = 0;
                    }
                    if(num1 != num2) {
                        num1++;
                        cont++;
                    }

                }
                return cont;
            }
        }
    }
}
