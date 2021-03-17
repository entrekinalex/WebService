using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;

namespace Services
{
    public interface IOrderService
    {
        OrderResult PlaceOrder(Order order);
    }
}
