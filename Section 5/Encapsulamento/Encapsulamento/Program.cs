using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome()); //exibindo o nome

            Console.WriteLine("Digite o nome que o produto vai ser alterado");
            string n = Console.ReadLine(); //criando variavel auxiliar
            p.SetNome(n); //colocando o nome na variavel auxiliar
            Console.WriteLine(p.GetNome()); //exibindo
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            //p._preco = 340.00; como agora ta private só se chamar a função get
        }
    }
}
