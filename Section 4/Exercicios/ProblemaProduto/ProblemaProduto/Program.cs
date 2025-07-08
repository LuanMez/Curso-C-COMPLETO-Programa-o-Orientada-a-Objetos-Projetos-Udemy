using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaProduto {
    class Program {
        static void Main(string[] args) {

            Produto p1;
            p1 = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(quant);
            Console.WriteLine("Dados do produto: " + p1);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quant = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(quant);
            Console.WriteLine("Dados do produto: " + p1);

        }
    }
}
