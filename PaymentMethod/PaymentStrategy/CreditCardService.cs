namespace PaymentMethod.PaymentStrategy;

// Payment Algorithm A
public class CreditCardService : IPayment
{
    public void Pay(Order order) =>
        Console.WriteLine($"Order {order.Id} payed with Credit Card");
}