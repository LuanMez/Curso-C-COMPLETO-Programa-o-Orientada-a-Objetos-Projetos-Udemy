using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Calculadora
    {
        public static void Triplo (ref int x) {
            x = x * 3;
        }
    }
}
