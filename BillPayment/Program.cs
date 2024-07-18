using BillPayment;

var paymentSlipService = new PaymentSlipService();

var customer = new CustomerInputModel
{
    Id = Guid.NewGuid(),
    FullName = "John Doe",
    Email = "john.doe@example.com",
    Document = "123456789"
};

var items = new List<OrderItemInputModel>
        {
            new OrderItemInputModel
            {
                ProductId = Guid.NewGuid(),
                Quantity = 2,
                Price = 19.99m
            },
            new OrderItemInputModel
            {
                ProductId = Guid.NewGuid(),
                Quantity = 1,
                Price = 9.99m
            }
        };

var deliveryAddress = new DeliveryAddressInputModel
{
    Street = "123 Main St",
    Number = "456",
    City = "Anytown",
    State = "Anystate",
    ZipCode = "12345"
};

var paymentAddress = new PaymentAddressInputModel
{
    Street = "123 Main St",
    Number = "456",
    City = "Anytown",
    State = "Anystate",
    ZipCode = "12345"
};

var paymentInfo = new PaymentInfoInputModel
{
    PaymentMethod = PaymentMethod.CreditCard,
    CardNumber = "4111111111111111",
    FullName = "John Doe",
    ExpirationDate = "12/25",
    Cvv = "123"
};

// Creating an instance of the OrderInputModel
var order = new OrderInputModel
{
    Customer = customer,
    Items = items,
    DeliveryAddress = deliveryAddress,
    PaymentAddress = paymentAddress,
    PaymentInfo = paymentInfo,
    IsInternational = false
};

// Maybe we need a builder for the OrderInputModel also, don't you think? But it's not the focus of this example.

Console.WriteLine(paymentSlipService.Process(order));
