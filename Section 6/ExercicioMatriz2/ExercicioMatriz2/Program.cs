using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];

            for (int l = 0; l < m; l++) {
                for (int c = 0; c < n; c++) {
                    mat[l, c] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite o numero que quer achar: ");
            int x = int.Parse(Console.ReadLine());

            for (int l = 0; l < m; l++) {
                for (int c = 0; c < n; c++) {

                    if (mat[l, c] == x) {
                        Console.WriteLine("POsição {0},{1}", l, c);
                        if (l > 0) {
                            Console.WriteLine("Cima: " + mat[l - 1, c]);
                        }
                        if (c < n - 1) {
                            Console.WriteLine("Direita: " + mat[l, c + 1]);
                        }
                        if (l < m -1) {
                            Console.WriteLine("Baixo: " + mat[l + 1, c]);
                        }
                        if (c > 0) {
                            Console.WriteLine("Esquerda: " + mat[l, c - 1]);
                        }
                    }
                }
            }
        }
    }
}
