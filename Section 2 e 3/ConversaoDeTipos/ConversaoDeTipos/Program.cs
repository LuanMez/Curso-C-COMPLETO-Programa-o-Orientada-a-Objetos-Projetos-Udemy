using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            //pode converter float para double pq float tem 4 bits e double tem 8
            //o contrario nao pode só com o casting
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            double a = 5.1;

            float b = (float) a; //agora to usando o casting

            int c = (int) a;//funciona mas perdeu informação pois double é decimal e int não

            Console.WriteLine(b);

            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double) d / e;//double vai armazenar int, tem que ter o casting para o mudar isso

            Console.WriteLine(resultado);
        }
    }
}
