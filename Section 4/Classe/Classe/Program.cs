using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe {
    class Program {
        static void Main(string[] args) {
            //Declarando x e y da classe triangulo
            Triangulo x, y;
            //Instanciando
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());//usando o atributo A na variavel x
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) /  2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = {0:F4}", areaX);
            Console.WriteLine("Área de Y = {0:F4}", areaY);

            if (areaX > areaY) {
                Console.WriteLine("Maior area: X");
            } else {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
