using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioImposto.Entities
{
    class Individual : User
    {
        public double Health { get; set; }

        public Individual (string name, double anualIncome, double health) : base (name, anualIncome){
            Health = health;
        }
    }
}
