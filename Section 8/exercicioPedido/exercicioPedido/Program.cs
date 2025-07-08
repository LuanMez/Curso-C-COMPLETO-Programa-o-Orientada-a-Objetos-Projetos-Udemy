using exercicioPedido.Entities;
using exercicioPedido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPedido {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

            DateTime data = DateTime.Now;
            //createOrder
            Order order = new Order(data, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine()!;

                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine()!);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine()!);

                Product product = new Product(productName, priceProduct);

                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}