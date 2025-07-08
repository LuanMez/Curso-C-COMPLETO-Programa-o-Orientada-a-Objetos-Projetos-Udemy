using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ExercicioClasseEnum.Entities;
using ExercicioClasseEnum.Entities.Enums;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's name: ");
            string deptname = Console.ReadLine()!;
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()!);

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine()!);

            //create new department
            Department dept = new Department(deptname);

            //create new worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int quant = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= quant; i++) {
                Console.WriteLine("Enter #{0} contract data: ", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine()!);

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine()!);

                Console.Write("Value per hour: ");
                int hours = int.Parse(Console.ReadLine()!);

                //create new hourContract
                HourContract hourcontract = new HourContract(date, valuePerHour, hours);

                //add contract for worker
                worker.addContract(hourcontract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYears = Console.ReadLine()!;
            int month = int.Parse(monthAndYears.Substring(0, 2));
            int year = int.Parse(monthAndYears.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Name: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYears + ": " + worker.Income(year, month));
        }
    }
}