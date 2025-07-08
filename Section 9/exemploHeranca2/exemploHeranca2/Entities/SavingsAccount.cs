using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca.Entities {
    //ao por sealed faz com que nenhuma classe pode herdar dessa.
    sealed class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount() {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        //ao por o sealed aqui nao pode ser sobrescrita novamente em outra classe
        public sealed override void Withdraw(double amount) {
            //Balance -= amount;

            base.Withdraw(amount); //reaproveita o Witchdraw da superclasse
            Balance -= 2.0;
        }
    }
}
