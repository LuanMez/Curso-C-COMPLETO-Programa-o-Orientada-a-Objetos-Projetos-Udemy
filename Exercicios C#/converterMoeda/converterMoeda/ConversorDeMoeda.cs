using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterMoeda
{
    class ConversorDeMoeda
    {
        public static double Conversao(double cotacao, double quant) {
            return (cotacao * quant) + ((cotacao * quant) * 0.06);
        }
    }
}
