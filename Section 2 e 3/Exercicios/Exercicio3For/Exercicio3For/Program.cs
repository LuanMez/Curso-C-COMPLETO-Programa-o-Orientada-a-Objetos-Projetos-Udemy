/*Leia 1 valor inteiro N, que representa o número de casos 
 * de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. 
Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 
2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3For
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz
            /*double[,] numeros = new double[3, n];*/
            //array
            /*double[] numeros = new double[5];
            double[] numeros = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] numeros = new double[] { 10.5, 20.5, 30.5 };*/

            Console.WriteLine("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Digite o valor de a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de c: ");
                double c = double.Parse(Console.ReadLine());

                double resultado = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10;
                Console.WriteLine($"{resultado:F1}");
            }


        }
    }
}
