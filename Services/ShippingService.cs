using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net;
using Microsoft.Extensions.Logging;

namespace Services
{
    public class ShippingService : IShippingService
    {
        private ISmtpClient mailService;
        private readonly ILogger<ShippingService> logger;
        private readonly MailboxAddress ShippingEmail = new("Shipping", "shipping@kelly.fake");
        private readonly MailboxAddress MyEmail = new("Orders", "orders@kelly.fake");
        public ShippingService(ISmtpClient mailService, ILogger<ShippingService> logger)
        {
            this.mailService = mailService;
            this.logger = logger;
        }
        public bool ShipOrder(ShippingDetails shippingDetails, OrderDetails orderDetails)
        {
            var message = new MimeMessage();
            message.Body = new TextPart("plain")
            {
                Text = GenerateEmailBody(shippingDetails, orderDetails)
            };
            message.To.Add(ShippingEmail);
            message.From.Add(MyEmail);
            try
            {
                mailService.Send(message);
                return true;
            }
            catch(Exception e)
            {
                logger.LogError(e.Message);
                return false;
            }
            
        }

        private string GenerateEmailBody(ShippingDetails shippingDetails, OrderDetails orderDetails)
        {
            return $"Send {orderDetails.ProductId} to {shippingDetails}";
        }
    }
}
