namespace PaymentMethod.PaymentStrategy;

// Payment Algorithm C
public class PixService : IPayment
{
    public void Pay(Order order) =>
        Console.WriteLine($"Order {order.Id} payed with Pix.");

}