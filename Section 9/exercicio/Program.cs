using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicio.Entities;

namespace exercicio {
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de produtos: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine()!);

                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!);

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine()!);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine()!);
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }

            foreach (var product in list)
            {
                Console.WriteLine(product.priceTag());
            }

        }
    }
}