using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class Order
    {
        private readonly List<OrderItem> _items = new();

        public IReadOnlyList<OrderItem> Items => _items.AsReadOnly();

        public required IPayment Payment { get; set; }
        public required IDelivery Delivery { get; set; }
        public required INotification Notification { get; set; }
        public required IDiscount Discount { get; set; }

        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        public double CalculateTotal()
        {
            var subtotal = _items.Sum(item => item.Total);
            return Discount != null ? Discount.ApplyDiscount(subtotal) : subtotal;
        }

        public void ProcessOrder()
        {
            double total = CalculateTotal();
            Payment?.ProcessPayment(total);
            Delivery?.DeliverOrder(this);
            Notification?.SendNotification($"Your order total is {total:C}. Thank you!");
        }
    }

}
