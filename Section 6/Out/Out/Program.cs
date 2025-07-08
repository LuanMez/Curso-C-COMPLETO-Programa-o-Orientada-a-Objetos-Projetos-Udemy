using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out
{
    class Program
    {
        static void Main(string[] args) {
            int x = 10;
            int triplo;
            Calculadora.Triplo(x, out triplo);//por red é por referencia altera o valor
            Console.WriteLine(triplo);
        }

    
    }
}
