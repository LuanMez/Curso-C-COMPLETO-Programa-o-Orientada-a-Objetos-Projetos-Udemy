using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Produto {
        //Atributos privados
        private string _nome; //padrao do c#

        //Propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Construtores
        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Propriedades customizadas
        public string Nome {//nao usar o ()
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;

                }
            }
        }

        //Outros métodos da classe
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
