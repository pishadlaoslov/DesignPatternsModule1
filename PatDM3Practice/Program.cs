using PatDM3Practice;

class Program
{
    static void Main()
    {
        
        var order = new Order
        {
            Payment = new PayPalPayment(),
            Delivery = new CourierDelivery(),
            Notification = new EmailNotification(),
            Discount = new PercentageDiscount(10) 
        };

        
        order.AddItem(new OrderItem("Laptop", 1, 1500));
        order.AddItem(new OrderItem("Mouse", 2, 25));

        
        order.ProcessOrder();
    }
}
