using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaFuncionario {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionarios serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //criação da lista de funcionario
            List<Funcionario> listaFun = new List<Funcionario>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Funcionario #" + (i+1));

                //criação de um funcionario novo
                Funcionario func = new Funcionario();

                Console.Write("Id: ");
                func.Id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                func.Nome = Console.ReadLine();

                Console.Write("Salario: ");
                func.Salario = double.Parse(Console.ReadLine());

                listaFun.Add(func);
            }

            Console.Write("Entre com o id do funcionario que vai receber aumento: ");
            int id = int.Parse(Console.ReadLine());

            int s1 = listaFun.FindIndex(x => x.Id == id);

            if (s1 >= 0 && s1 < n) {
                Console.Write("Digite a porcentagem par aumentar: ");
                double porcentagem = double.Parse(Console.ReadLine());

                listaFun[s1].AdicionarSalario(porcentagem);

            } else {
                Console.WriteLine("Id não existente! ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Atualização da Lista");
            foreach (Funcionario obj in listaFun) {
                Console.WriteLine(obj);
            }
        }
    }
}
