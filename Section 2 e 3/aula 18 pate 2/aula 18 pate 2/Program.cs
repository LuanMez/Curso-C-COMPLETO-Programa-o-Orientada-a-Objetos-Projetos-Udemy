using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_18_pate_2 {
    class Program {
        static void Main(string[] args) {

            int idade = 32;
            double saldo = 2323.4324332;
            string nome = "Maria";

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais"); //concatenação oq eu sabia kkkk
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Exercicio");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte udade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}\n", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}\n", idade, codigo, genero);
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culturre: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
