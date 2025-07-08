using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco {
    class Conta {

        public double Valor { get; private set; }
        public int Numero { get; private set; } //pode ver mas nao pode mudar
        public string Nome { get; set; }//pode ver e pode mudar

        public Conta(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double valor) : this (numero, nome){
            Adicionar(valor);
        }

        public void Adicionar(double valor) {
            Valor += valor;
        }

        public void Sacar(double valor) {
            Valor -= (valor + 5);
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: " + "$ " + Valor.ToString("F2");

        }
    }
}
