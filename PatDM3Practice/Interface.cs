using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public interface IPayment
    {
        void ProcessPayment(double amount);
    }

    public interface IDelivery
    {
        void DeliverOrder(OrderItem order);
        void DeliverOrder(Order order);
    }

    public interface INotification
    {
        void SendNotification(string message);
    }

    public interface IDiscount
    {
        double ApplyDiscount(double total);
    }
}
