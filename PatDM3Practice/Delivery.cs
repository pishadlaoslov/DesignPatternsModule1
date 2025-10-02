using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class CourierDelivery : IDelivery
    {
        public void DeliverOrder(OrderItem order)
        {
            Console.WriteLine($"Order will be delivered by courier.");
        }

        public void DeliverOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }

    public class PostDelivery : IDelivery
    {
        public void DeliverOrder(OrderItem order)
        {
            Console.WriteLine($"Order will be sent via post.");
        }

        public void DeliverOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }

    public class PickUpPointDelivery : IDelivery
    {
        public void DeliverOrder(OrderItem order)
        {
            Console.WriteLine($"Order will be available at pickup point.");
        }

        public void DeliverOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }

}
