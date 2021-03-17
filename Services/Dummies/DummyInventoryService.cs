using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Services.Dummies
{
    public class DummyInventoryService : IInventoryService
    {

        public bool CheckInventory(string productId, int qty)
        {
            Console.WriteLine($"Checking for inventory {qty} of {productId}");
            return true;
        }
    }
}
