using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Calculadora.Triplo(ref x);
            Console.WriteLine(x);
        }
    }
}
