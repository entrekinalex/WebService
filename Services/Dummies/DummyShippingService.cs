using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dummies
{
    class DummyShippingService : IShippingService
    {
        public bool ShipOrder(ShippingDetails shippingDetails, OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }
    }
}
