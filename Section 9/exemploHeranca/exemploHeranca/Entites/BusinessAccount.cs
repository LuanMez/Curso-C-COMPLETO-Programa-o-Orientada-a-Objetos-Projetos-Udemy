using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHeranca.Entites {
    class BusinessAccount : Account {
        public double Loanlimit { get; set; }

        /* Uma forma de criar os contrutores
        public BusinessAccount(int number, string holder, double balance, double loanlimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            Loanlimit = loanlimit;
        }*/

        public BusinessAccount(int number, string holder, double balance, double loanlimit) 
            : base(number, holder, balance){
            Loanlimit = loanlimit;
        }

        public void Loan (double amount) {
            if(Loanlimit >= amount) {
                Balance += amount;
            }
        }
    }
}
