using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {

            double? x = null; //recebe o valor de null
            double? y = 10.0; //recebe o valor de 10

            //verifica se tem um valor e se n tiver fica  valor padrao 0 
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            // exemplo com ??
            double? z = null;
            double? v = 10;

            //se o valor que receber for null entao recebe 5 se tiver valor
            //recebe a propria varaivel
            double c = z ?? 5;
            double d = v ?? 5;

            Console.WriteLine(z);
            Console.WriteLine(v);
        }
    }
}
