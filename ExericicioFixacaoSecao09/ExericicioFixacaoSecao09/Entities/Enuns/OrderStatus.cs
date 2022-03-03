using System;
using System.Collections.Generic;
using System.Text;

namespace ExericicioFixacaoSecao09.Entities.Enuns
{
    enum OrderStatus : int
    {
        PEDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}
