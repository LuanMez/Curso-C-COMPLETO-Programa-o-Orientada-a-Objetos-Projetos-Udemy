/*Escreva um programa que repita a leitura de uma senha 
até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". 
Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo 
encerrado. Considere que a senha correta é o valor 2002.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01While
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste = 0;

            while(teste != 2002) {
                Console.WriteLine("Digite a senha correta: ");
                teste = int.Parse(Console.ReadLine());
                if(teste != 2002) {
                    Console.WriteLine("Senha Invalida");
                }
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
