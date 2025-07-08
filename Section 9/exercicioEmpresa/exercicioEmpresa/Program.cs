using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using exercicioEmpresa.Entities;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();


            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsourced (y/n)? ");
                char x = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHour: ");
                double valuePerHours = double.Parse(Console.ReadLine());

                if (x == 'Y' || x == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                } else {
                    employee.Add(new Employee(name, hours, valuePerHours));
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee x in employee) {
                Console.WriteLine(x.Name + " - $ " + x.Payment());
            }
        }
    }
}