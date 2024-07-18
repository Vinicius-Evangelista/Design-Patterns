namespace BillPayment;

public interface IPaymentService
{
    public object Process(OrderInputModel model);
}
