using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Hotel {
    class Program {
        static void Main(string[] args) {

            const int quarto = 10;

            Estudante[] vet = new Estudante[quarto];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu email");
                string email = Console.ReadLine();

                Console.WriteLine("Digite seu quarto");
                int num = int.Parse(Console.ReadLine());

                vet[num] = new Estudante { Nome = nome, Email = email};

            }
            Console.WriteLine("Quartos alugados:");

            for (int i = 0; i < quarto; i++) {
                if (vet[i] != null) {
                    Console.WriteLine("{0}: {1}, {2}", i, vet[i].Nome, vet[i].Email);
                }
            }

        }
    }
}

