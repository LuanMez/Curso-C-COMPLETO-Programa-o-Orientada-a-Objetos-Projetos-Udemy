using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaFuncionario
{
    class Funcionario
    {

        public int Id { get; set; }

        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AdicionarSalario (double porcentagem) {
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        public override string ToString() {
            return Id
            + ", "
            + Nome
            + ", "
            + Salario.ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
