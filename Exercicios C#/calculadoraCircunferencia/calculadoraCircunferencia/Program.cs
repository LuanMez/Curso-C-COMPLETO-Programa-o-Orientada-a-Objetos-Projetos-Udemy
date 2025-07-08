using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraCircunferencia {
    class Program {
        


        static void Main(string[] args) {

            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Pi: " + calc.Pi.ToString("F2"));
        }

        
    }
}
