using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Order
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentDetails)
        {
            Console.WriteLine("Payment processed using: " + paymentDetails);
        }
    }
}
