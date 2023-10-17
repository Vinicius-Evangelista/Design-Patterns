namespace PaymentMethod.PaymentStrategy;

// Strategy Pattern Interface
public interface IPayment
{
    public void Pay(Order order);
}