using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IInventoryService inventoryService;
        private readonly IPaymentService paymentService;
        private readonly IShippingService shippingService;

        public OrderService(IInventoryService inventoryService, IPaymentService paymentService, IShippingService shippingService)
        {
            this.inventoryService = inventoryService;
            this.paymentService = paymentService;
            this.shippingService = shippingService;
        }

        public OrderResult PlaceOrder(Order order)
        {
            var inStock = inventoryService.CheckInventory(order.OrderDetails.ProductId, 1);
            if (!inStock)
            {
                return OrderResult.OUT_OF_STOCK;
            }
            var paymentAccepted = paymentService.MakePayment(order.PaymentDetails);
            if(!paymentAccepted)
            {
                return OrderResult.PAYMENT_FAILURE;
            }
            var successfullyShipped = shippingService.ShipOrder(order.ShippingDetails, order.OrderDetails);
            if (!successfullyShipped)
            {
                return OrderResult.SHIPPING_FAILURE;
            }
            return OrderResult.SUCCESS;
        }
    }
}
