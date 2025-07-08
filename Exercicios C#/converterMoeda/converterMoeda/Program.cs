using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversao(cotacao, quant).ToString("F2"));
        }
    }
}
