/*Fazer um programa para ler o nome de um aluno e as 
três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem
35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e,
em caso negativo, quantos pontos faltam para o aluno obter
o mínimo para ser aprovado (que é 60 pontos). Você deve criar
uma classe Aluno para resolver este problema.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração da variavel aluno1
            Aluno aluno1;
            aluno1 = new Aluno();


            Console.Write("Nome do Aluno: ");
            aluno1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final = " + aluno1.NotaFinal());

            if(aluno1.NotaFinal() > 60.0) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno1.Faltou().ToString("F2") + " PONTOS");
            }
        }
    }
}
