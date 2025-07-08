/*Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa;

            pessoa = new Funcionario();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + pessoa);


            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            pessoa.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + pessoa);
        }
    }
}
