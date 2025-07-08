using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioImposto.Entities
{
    abstract class User
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public User (string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }


    }
}
