using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o numero de alturas que vai ser inserido: ");
            int num = int.Parse(Console.ReadLine());

            double[] vet = new double[num]; //criação de um vetor com 3 elementos

            double soma = 0.0;

            for(int i = 0; i < num; i++) {
                Console.Write("Digite a {0}° altura: ", i);
                vet[i] = double.Parse(Console.ReadLine());
                soma += vet[i];
            }

            //calculo da media
            double media = soma / num;
            Console.WriteLine("Media das alturas {0:F2}", media);
        }
    }
}
