using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            //adicionando membros a lista com Add
            //lista de produtos = lista.Add(new Produto());
            //Add adiciona ao final da lista semmpre
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco");
            //Insert ele adiciona onde voce quiser.
            //adiciona e já empurra as outras para
            //continuarem na lista e nao ser substituida.
          

            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista: " + lista.Count);
            //Count pega o tamanho da lista

            //achar o primeiro elemento q começa com 'A'
            string s1 = lista.Find(Test);
            Console.WriteLine("Primeiro que começa com 'A': " + s1);

            //achar o ultimo elemento q começa com 'A'
            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo que começa com 'A': " + s2);

            //achar a primeira posição q começa com 'A'
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição com 'A': " + pos1);

            //achar a ultima posição q começa com 'A'
            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição com 'A': " + pos2);

            Console.WriteLine("--------------------------------");

            //criar uma nova lista que contemplem o predicado.
            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string obj in lista2) {
                Console.WriteLine(obj);
            }

            //remove o elemento que ele achar
            lista.Remove("Alex");
            Console.WriteLine("--------------------------------");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //remove todos que ele achar que forem iguais
            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            /*//remove o elemento da posição
            lista.RemoveAt(3); 
            Console.WriteLine("--------------------------------");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            //remove o elemento da posição e quantidade em seguida
            lista.RemoveRange(2,2);//]]
            Console.WriteLine("--------------------------------");
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }*/



        }

        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
}
