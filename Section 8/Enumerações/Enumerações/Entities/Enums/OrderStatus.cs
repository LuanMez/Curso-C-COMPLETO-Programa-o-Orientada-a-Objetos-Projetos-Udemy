using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerações.Entities.Enums
{
    enum OrderStatus : int
    {
        //se por nada o valor atribuido vai ser 0
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
