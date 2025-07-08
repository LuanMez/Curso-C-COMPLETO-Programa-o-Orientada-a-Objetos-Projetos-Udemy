using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula18 {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.3543435;
            string nome = "Maria";

            Console.Write("Ola"); //nao faz quebra de linha
            Console.WriteLine("Tudo bem"); //faz quebra de linha
            Console.WriteLine("Salve");
            Console.WriteLine("------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F4"));//mostrar apenas quatrro valores decimais
            Console.WriteLine(saldo.ToString("F2"));//mostrar apenas dois valores decimais
            //isso foi paa mostrar o numero com o . em vez do ,
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
        }
    }
}
