using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    public class BankTransferPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Bank Transfer.");
        }
    }

}
