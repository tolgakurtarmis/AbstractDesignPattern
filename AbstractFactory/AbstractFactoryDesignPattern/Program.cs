using AbstractFactoryDesignPattern;
using AbstractFactoryDesignPattern.PaymentSystem.CreditCard;
using AbstractFactoryDesignPattern.PaymentSystem.Interfaces;
using AbstractFactoryDesignPattern.PaymentSystem.PayPal;
using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ödeme yöntemi seçin: creditcard / paypal");
        var input = Console.ReadLine();

        if (Enum.TryParse<PaymentType>(input, true, out var paymentType))
        {
            IPaymentService paymentService = new PaymentFactory().CreatePaymentService(paymentType);
            paymentService.Pay(1500m);
        }
        else
        {
            Console.WriteLine("❌ Geçersiz ödeme yöntemi.");
        }


        Console.ReadKey();
    }
}