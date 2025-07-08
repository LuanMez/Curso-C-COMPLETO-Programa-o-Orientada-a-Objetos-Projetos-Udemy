using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02Classe {
    class Program {
        static void Main(string[] args) {
            Funcionario pessoa1, pessoa2;

            pessoa1 = new Funcionario();
            pessoa2 = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.Salario = double.Parse(Console.ReadLine());

            double mediaSalarial = (pessoa1.Salario + pessoa2.Salario) / 2.0;
            Console.WriteLine("Salario medio = {0:F2}", mediaSalarial);

        }
    }
}
