using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class OrderItem
    {
        public string ProductName { get; }
        public int Quantity { get; }
        public double Price { get; }

        public OrderItem(string name, int quantity, double price)
        {
            ProductName = name;
            Quantity = quantity;
            Price = price;
        }

        public double Total => Quantity * Price;
    }

}
