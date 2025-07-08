using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLivro
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando o livro
            Livro l;

            Console.Write("Digite o nome do livro a ser cadastrado: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o codigo do livro: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite se vai ter quantidade inicial de livros (s/n): ");
            char verificar = char.Parse(Console.ReadLine());
            int quant; //criar a variavel fora do if
            if (verificar == 's' || verificar == 'S') {
                Console.Write("Digite a quantidade de livros: ");
                quant = int.Parse(Console.ReadLine());
                l = new Livro(codigo, titulo, quant);
            } else {
                l = new Livro(codigo, titulo);
            }

            Console.WriteLine("Dados do Livro: \n" + l);

            Console.Write("Digite a quantidade de livros que chegou no estoque: ");
            quant = int.Parse(Console.ReadLine());
            l.AumentarEstoque(quant);

            Console.WriteLine("Dados do Livro atualizado: \n" + l);

            Console.Write("Digite a quantidade de livros que foi feito emprestimo: ");
            quant = int.Parse(Console.ReadLine());
            l.Emprestimo(quant);

            Console.WriteLine("Dados do Livro atualiuzado: \n" + l);

        }
    }
}
