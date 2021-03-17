using System;

namespace Services.Models
{
    public class Order
    {
        public ShippingDetails ShippingDetails { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public OrderDetails OrderDetails { get; set; }
        
    }

    public class OrderDetails
    {
        // Currently assuming a single item
        public string ProductId { get; set; }
    }


    public enum OrderResult
    {
        OUT_OF_STOCK,
        PAYMENT_FAILURE,
        SHIPPING_FAILURE,
        SUCCESS
    }
}
