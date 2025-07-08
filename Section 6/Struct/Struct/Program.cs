using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct {
    class Program {
        static void Main(string[] args) {
            Point p;
            //nao precisa do Pint p = new Point ();, pois struct nao é objeto.
            p.X = 10; //tem que iniciar valor.
            p.Y = 20;
            /*pode tambem por assim
             Point p = new Point();*/
            Console.WriteLine(p);
        }
    }
}
