using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Objeto {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vet[i] = new Produto { Nome = nome, Preco = preco };
                soma += vet[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("A media {0}", media);
        }
    }
}
