using Enumerações.Entities; //ver a pasta entities
using Enumerações.Entities.Enums; //ver a pasta entities
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeDoPrograma {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);

            //Converter Enums para string
            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //Converter string para Enums
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}