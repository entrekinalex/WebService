using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dummies
{
    public class DummyPaymentService : IPaymentService
    {
        public bool MakePayment(PaymentDetails details)
        {
            throw new NotImplementedException();
        }
    }
}
