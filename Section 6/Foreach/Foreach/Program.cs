using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args) {
            string[] vet = new string[] { "Maria", "Joao", "Feijao" };

            foreach( string nome in vet) {
                Console.WriteLine(nome);
            }

        }
    }
}
