﻿/*Em um banco, para se cadastrar uma conta bancária,
 * é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o
titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular
não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial
da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o
número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode
mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. 
É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui 
por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta 
pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma 
conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar 
um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco {
    class Program {
        static void Main(string[] args) {

            Conta nova;

            Console.Write("Entre o número da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da Conta: ");
            string titularConta = (Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n): ");
            char verificar = char.Parse(Console.ReadLine());

            double valorConta = 0;
            if (verificar == 's' || verificar == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                valorConta = double.Parse(Console.ReadLine());
                nova = new Conta(numeroConta, titularConta, valorConta);
                Console.WriteLine("Dados da conta:\n" + nova);
            } else {
                nova = new Conta(numeroConta, titularConta);
                Console.WriteLine("Dados da conta:\n" + nova);
            }

            Console.Write("Entre um valor para depósito: ");
            valorConta = double.Parse(Console.ReadLine());
            nova.Adicionar(valorConta);
            Console.WriteLine("Dados da conta atualizados:\n" + nova);

            Console.Write("Entre um valor para saque: ");
            valorConta = double.Parse(Console.ReadLine());
            nova.Sacar(valorConta);
            Console.WriteLine("Dados da conta atualizados:\n" + nova);

        }
    }
}
