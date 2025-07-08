using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using exemploHeranca.Entities; //escrevi errado

namespace exemploHerenca2 {
    class Program {
        static void Main(string[] args) {
            Account acc1 = new Account(232, "Roberto", 500.0); ;
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}