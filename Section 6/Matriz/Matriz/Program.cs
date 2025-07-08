using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            //criando uma matriz
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //quantos elementos tem no total

            Console.WriteLine(mat.Rank); //quantas linhas tem

            Console.WriteLine(mat.GetLength(0)); //primeira dimensao tem 2 linhas

            Console.WriteLine(mat.GetLength(1)); //segunda dimensao tem 3 colunas
        }
    }
}
