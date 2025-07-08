using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExercicioMatriz {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o numero da matriz quadrada: ");

            int n = int.Parse(Console.ReadLine());
            int cont = 0;

            double[,] mat = new double[n, n];

            for (int l = 0; l < n; l++) {
                for (int c = 0; c < n; c++) {
                    mat[l, c] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal da matriz: ");
            for (int l = 0; l < n; l++) {
                for (int c = 0; c < n; c++) {

                    if(l == c) {
                        Console.Write(mat[l, c] + " ");
                    }
                    if (mat[l, c] < 0) {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Numeros Negativos = : " + cont);
        }
    }
}
