using PaymentMethod.PaymentStrategy;

namespace PaymentMethod;

public abstract class PaymentFactory
{
    public static IPayment CreatePayment(PaymentType payment)
    {
        switch (payment)
        {
            case PaymentType.CreditCard:
                return new CreditCardService();
                
            case PaymentType.Pix:
                return new PixService();

            case PaymentType.PaymentSlip:
                return new PaymentSlipService();
            
            default:
                throw new ApplicationException("Meio de pagamento não reconhecido");
            
        }
    }
}
