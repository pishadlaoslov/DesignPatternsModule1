using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Order
{
    public class Order
    {
        public string ProductName { get; }
        public int Quantity { get; }
        public double Price { get; }

        public Order(string productName, int quantity, double price)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}
