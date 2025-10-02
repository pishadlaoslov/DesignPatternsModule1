using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM2L1
{
    public class OrderService
    {
        public void CreateOrder(string productName, int quantity, double price)
        {
            PrintOrderMessage("created", productName, quantity, price);
        }

        public void UpdateOrder(string productName, int quantity, double price)
        {
            PrintOrderMessage("updated", productName, quantity, price);
        }

        private void PrintOrderMessage(string action, string productName, int quantity, double price)
        {
            double totalPrice = CalculateTotalPrice(quantity, price);
            Console.WriteLine($"Order for {productName} {action}. Total: {totalPrice}");
        }

        private double CalculateTotalPrice(int quantity, double price)
        {
            return quantity * price;
        }
    }

}
