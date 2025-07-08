using exercicioFIxação.Entities;
using exercicioFIxação.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixação {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Holder: ");
            string holder = Console.ReadLine()!;

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine()!);

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine()!);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine()!);

            try {
                account.withdraw(amount);
                Console.WriteLine("New balçance: " + account.Balance.ToString("F2"));

            } catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}