using PaymentMethod;

var order = new Order("Carrinho de Controle Remoto");

var orderService1 = new OrderService(PaymentFactory.CreatePayment(PaymentType.Pix));
orderService1.Pay(order);

var orderService2 = new OrderService(PaymentFactory.CreatePayment(PaymentType.PaymentSlip));
orderService2.Pay(order);

var orderService3 = new OrderService(PaymentFactory.CreatePayment(PaymentType.CreditCard));
orderService3.Pay(order);