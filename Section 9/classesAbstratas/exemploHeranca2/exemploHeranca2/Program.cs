﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using exemploHeranca.Entities; //escrevi errado

namespace exemploHerenca2 {
    class Program {
        static void Main(string[] args) {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sum = 0.0;

            foreach( Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach (var acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (var acc in list) {
                Console.WriteLine("U´pdate balance or account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2"));
            }
        }
    }
}