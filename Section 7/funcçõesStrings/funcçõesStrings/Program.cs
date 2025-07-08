using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcçõesStrings {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper(); //faz todos ficarem maisculos
            string s2 = original.ToLower(); //faz todos ficarem minusculas
            string s3 = original.Trim(); //tira os espaços brancos antes e dps da string

            int n1 = original.IndexOf("bc"); //acha a posição da string que contem o conteudo
            int n2 = original.LastIndexOf("bc"); //acha a posição ultima posição na string

            string s4 = original.Substring(3); //cria uma nova string a partir de uma posição
            string s5 = original.Substring(3, 6); //cria uma nova string a partir de uma posição e quantos após

            string s6 = original.Replace('a', 'x'); //troca o caracter a pelo x
            string s7 = original.Replace("abc", "xy"); //troca o caracter a pelo x

            bool b1 = String.IsNullOrEmpty(original); //verifica se ta nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //verifica se esta nula ou espaços em branco

            Console.WriteLine("Original: |" + original + "|");
            Console.WriteLine("ToUpper: |" + s1 + "|");
            Console.WriteLine("ToLower: |" + s2 + "|");
            Console.WriteLine("Trim: |" + s3 + "|");
            Console.WriteLine("IndexOf: 'bc'|" + n1 + "|");
            Console.WriteLine("LAstIndexOf: 'bc'|" + n2 + "|");
            Console.WriteLine("SubString(3):|" + s4 + "|");
            Console.WriteLine("SubString(3):|" + s5 + "|");
            Console.WriteLine("SubString(3):|" + s6 + "|");
            Console.WriteLine("SubString(3):|" + s7 + "|");
            Console.WriteLine("IsNullOrEmpty:|" + b1 + "|");
            Console.WriteLine("IsNullOrWhiteSpace:|" + b2 + "|");
        }
    }
}
