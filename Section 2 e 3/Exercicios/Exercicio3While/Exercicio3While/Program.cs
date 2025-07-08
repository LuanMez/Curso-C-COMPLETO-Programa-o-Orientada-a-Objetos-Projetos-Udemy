/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
Exemplo:
Entrada:    Saída:
8           MUITO OBRIGADO
1           Alcool: 1
7           Gasolina: 2
2           Diesel:
2
4*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um codigo de 1 a 3 e 4 para finalizar o programa");
            int opcao = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (opcao != 4) {
                switch (opcao) {
                    case 1:
                        alcool++;
                        Console.WriteLine("Digite um codigo de 1 a 3 e 4 para finalizar o programa");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        gasolina++;
                        Console.WriteLine("Digite um codigo de 1 a 3 e 4 para finalizar o programa");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        diesel++;
                        Console.WriteLine("Digite um codigo de 1 a 3 e 4 para finalizar o programa");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        opcao = 4;
                        Console.WriteLine("Digite um codigo de 1 a 3 e 4 para finalizar o programa");
                        break;
                    default:
                        Console.WriteLine("Digite um codigo Valido");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}
