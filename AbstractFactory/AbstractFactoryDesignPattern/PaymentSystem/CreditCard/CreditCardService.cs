using AbstractFactoryDesignPattern.PaymentSystem.Interfaces;

namespace AbstractFactoryDesignPattern.PaymentSystem.CreditCard
{
    public class CreditCardService:IPaymentService
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment of {amount:C} made using Credit Card.");
        }
    } 
}
