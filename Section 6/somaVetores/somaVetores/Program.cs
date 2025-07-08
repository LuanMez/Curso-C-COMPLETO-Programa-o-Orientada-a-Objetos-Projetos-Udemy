using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaVetores {
    class Program {
        static void Main(string[] args) {
            //sem o params ficaria assim 
            //int s1 = Calculadora.Soma(new int[] { 2, 4, 5, 7, 8 });

            //com params
            int s1 = Calculadora.Soma(2, 4, 5, 7, 8 );
            Console.WriteLine(s1);
        }
    }
}
