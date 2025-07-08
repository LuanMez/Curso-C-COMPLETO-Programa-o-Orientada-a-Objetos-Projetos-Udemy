using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioImposto.Entities
{
    class Company : User
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome) {
            Employees = employees;
        }
    }
}
