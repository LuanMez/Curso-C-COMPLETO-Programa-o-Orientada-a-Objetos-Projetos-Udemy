using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome); //exibindo o nome nao usa () na properties

            Console.WriteLine("Digite o nome que o produto vai ser alterado");
            string n = Console.ReadLine(); //criando variavel auxiliar
            p.Nome = n; //colocando o nome na variavel auxiliar
            Console.WriteLine(p.Nome); //exibindo
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //p._preco = 340.00; como agora ta private só se chamar a função get
        }
    }
}
