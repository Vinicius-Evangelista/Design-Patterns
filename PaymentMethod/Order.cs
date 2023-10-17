namespace PaymentMethod;

public class Order
{
    public Guid Id { get; set; }

    public string Item { get; set; }

    public Order(string item)
    {
        Item = item; 
        Id = Guid.NewGuid();
    }
}
