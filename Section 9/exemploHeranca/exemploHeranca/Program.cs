using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemploHeranca.Entites; //escrevi errado

namespace exemploHerenca {
    class Program {
        static void Main(string[] args) {

            Account account = new Account(134, "Beltrano", 0.0);

            BusinessAccount baccount = new BusinessAccount(1123, "Fulano", 0.00, 600.00);

            Console.WriteLine(account.Balance); //pode exibir mas nao mudar

            // account.Balance = 200.0;

            account.Deposit(5000.00);

            Console.WriteLine(account.Balance);
            //para mudar só chamando os metodos, nao podendo mudar direto no codigo interessante


            //UPCASTING
            Account acc1 = baccount; //pode converter pois Business account e subclasse de Account
            Account acc2 = new BusinessAccount (1002, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1032, "Ana", 0.0, 0.01);


            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //linha da erro pois acc3 é SavingsAccount
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount) { //verifica se a variavel é uma instancia de BusinessAccount
                //CASTING
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount) { //verifica se a variavel é uma instancia de BusinessAccount
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;


                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}