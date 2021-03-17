using System;

namespace Services
{
    public interface IInventoryService
    {
        bool CheckInventory(string productId, int qty);
    }
}
