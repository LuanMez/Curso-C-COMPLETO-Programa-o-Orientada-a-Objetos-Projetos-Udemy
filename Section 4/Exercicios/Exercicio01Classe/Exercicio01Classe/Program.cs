/*Fazer um Programa para ler os dados de duas pessoas, 
depois mostrar o nome da pessoa mais velha.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Classe {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            } else {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }

        }
    }
}
