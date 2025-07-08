using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            long n4 = 214783647L; //usar L no final quando utilizar long
            bool completo = false;
            char genero = 'M'; //aspas simples com char
            char letra = '\u0041'; //codigo A da tabela unicode
            float n5 = 4.5f; //quando utiklizar float tem que por o f no final
            double n6 = 4.5; //´já o double nao precisa
            string nome = "Luan Menezes"; //aspas dupla com string
            object obj1 = "Maria Green"; //o tipo object é um tipo generio ele aceita qualquer coisa
            object obj2 = 4.5f;

            int x1 = int.MaxValue;
            int x2 = int.MinValue;
            sbyte x3 = sbyte.MinValue;
            decimal x4 = decimal.MaxValue;

            /*Se escrever cw e apertar o tab já vai direto Console.WirteLine*/
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("Agora os valorres maximos e minimos");
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);





        }
    }
}
