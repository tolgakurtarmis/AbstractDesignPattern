using AbstractFactoryDesignPattern.PaymentSystem.Interfaces;

namespace AbstractFactoryDesignPattern.PaymentSystem.PayPal
{
    public class PayPalService : IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} made using PayPal.");
        }
    }
}
