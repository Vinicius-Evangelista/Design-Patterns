using PaymentMethod.PaymentStrategy;

namespace PaymentMethod;

public class OrderService : IOrderService
{
    //Strategy Pattern
    private readonly IPayment payment;

    public OrderService(IPayment payment)
    {
        this.payment = payment;
    }

    public void Pay(Order order)
    {
        payment.Pay(order);
    }
}
