using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Order.Order
{
    public class EmailService
    {
        public void SendConfirmationEmail(string email)
        {
            Console.WriteLine("Confirmation email sent to: " + email);
        }
    }
}
