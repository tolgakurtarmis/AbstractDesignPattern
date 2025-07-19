using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.PaymentSystem.Interfaces
{
    public interface IPaymentFactory
    {
        IPaymentService CreatePaymentService(PaymentType paymentType);
    }
}
