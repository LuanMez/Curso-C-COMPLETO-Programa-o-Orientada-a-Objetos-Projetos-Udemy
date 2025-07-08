using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTriangulo02
{
    class Triangulo {
        //public quer dizer que pode ser acessada por outro arquivo.
        public double A; //Atributo começa com letra maiuscula
        public double B;
        public double C;

        //Metodo, é fuma função dentro da classe.
        //Noa tem parametros por estar dentro da classe
        public double Area() {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
