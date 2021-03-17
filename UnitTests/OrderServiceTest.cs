using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services;
using Services.Models;

namespace UnitTests
{
    [TestClass]
    public class OrderServiceTest
    {
        
        private Mock<IInventoryService> inventoryService = new();
        private Mock<IPaymentService> paymentService = new();
        private Mock<IShippingService> shippingService = new();
        private OrderService orderService;
        private Order defaultOrder = new()
        {
            OrderDetails = new OrderDetails
            {
                ProductId = "test"
            },
            ShippingDetails = new ShippingDetails
            {
                

            },
            PaymentDetails = new PaymentDetails
            {
                
            }
        };
        [TestInitialize]
        public void BuildUp()
        {
            inventoryService.Reset();
            paymentService.Reset();
            shippingService.Reset();
            orderService = new OrderService(inventoryService.Object,
                paymentService.Object,
                shippingService.Object);
            inventoryService.Setup(x => x.CheckInventory(
                It.IsAny<string>(), It.IsAny<int>()))
                .Returns(true);
            paymentService.Setup(x => x.MakePayment(It.IsAny<PaymentDetails>()))
                .Returns(true);
            shippingService.Setup(x => x.ShipOrder(
                It.IsAny<ShippingDetails>(), It.IsAny<OrderDetails>()))
                .Returns(true);
        }

        [TestMethod]
        public void Succeed()
        {
            var result = orderService.PlaceOrder(defaultOrder);
            Assert.IsTrue(result == OrderResult.SUCCESS);
        }
        [TestMethod]
        public void FailsOnNoInventory()
        {
            inventoryService.Setup(x => x.CheckInventory(
                It.IsAny<string>(), It.IsAny<int>()))
                .Returns(false);
            var result = orderService.PlaceOrder(defaultOrder);
            Assert.IsTrue(result == OrderResult.OUT_OF_STOCK);
        }
        [TestMethod]
        public void FailsOnNoPayment()
        {
            paymentService.Setup(x => x.MakePayment(
                It.IsAny<PaymentDetails>()))
                .Returns(false);
            var result = orderService.PlaceOrder(defaultOrder);
            Assert.IsTrue(result == OrderResult.PAYMENT_FAILURE);
        }
        [TestMethod]
        public void FailsOnNoShipment()
        {
            shippingService.Setup(x => x.ShipOrder(
                It.IsAny<ShippingDetails>(), It.IsAny<OrderDetails>()))
                .Returns(false);
            var result = orderService.PlaceOrder(defaultOrder);
            Assert.IsTrue(result == OrderResult.SHIPPING_FAILURE);
        }
    }
}
