﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPedido.Entities.Enums {
    enum OrderStatus : int {

        Pending_Payment = 0,

        Processing = 1,

        Shipped = 2,

        Delivered = 3
    }
}
