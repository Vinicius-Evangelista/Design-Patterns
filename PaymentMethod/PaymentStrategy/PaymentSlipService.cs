namespace PaymentMethod.PaymentStrategy;

// Payment Algorithm B
public class PaymentSlipService : IPayment
{
    public void Pay(Order order) =>
        Console.WriteLine($"Order {order.Id} payed with Payment Slip.");
}