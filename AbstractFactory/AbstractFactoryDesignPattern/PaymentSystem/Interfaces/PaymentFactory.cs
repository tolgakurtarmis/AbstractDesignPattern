namespace AbstractFactoryDesignPattern.PaymentSystem.Interfaces
{
    public class PaymentFactory : IPaymentFactory
    {
        public IPaymentService CreatePaymentService(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    return new CreditCard.CreditCardService();
                case PaymentType.PayPal:
                    return new PayPal.PayPalService();
                default:
                    throw new NotSupportedException($"Payment type {paymentType} is not supported.");
            }
        }
    }
}
