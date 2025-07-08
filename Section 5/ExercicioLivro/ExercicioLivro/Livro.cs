using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLivro
{
    class Livro
    {
        public int Codigo { get; private set; }
        public string Titulo { get; set; }
        public int Quantidade { get; private set; }

        public Livro (int codigo, string titulo) {
            Codigo = codigo;
            Titulo = titulo;
            //nao precisa por que Quantidade = 0; j[a fica subentendido
        }

        public Livro (int codigo, string titulo, int quantidade) : this (codigo, titulo) {
            AumentarEstoque(quantidade);
        }

        public void AumentarEstoque( int quantidade) {
            Quantidade += quantidade;
        }

        public void Emprestimo(int quantidade) {
            if (Quantidade >= quantidade) {
                Quantidade -= quantidade;
            } else {
                Console.WriteLine("Empréstimo não realizado. Estoque insuficiente.");
            }
        }

        public override string ToString() {
            return "Código do livro: " + Codigo + " Título do livro: " + Titulo + " Quantidade: " + Quantidade;
        }
    }
}
