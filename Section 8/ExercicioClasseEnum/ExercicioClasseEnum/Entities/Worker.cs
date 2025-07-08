using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioClasseEnum.Entities;
using ExercicioClasseEnum.Entities.Enums;
using Microsoft.VisualBasic;

namespace ExercicioClasseEnum.Entities
{
    class Worker
    {
        public string Name { get; set; } = string.Empty;

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        //One departament is prop normal
        public Department Department { get; set; }

        //As there are several contracts, use a list
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() {

        }
        //do not use list in constructor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

        }

        public void addContract(HourContract contract) {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts) {
                if(year == contract.Date.Year && month == contract.Date.Month) {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
