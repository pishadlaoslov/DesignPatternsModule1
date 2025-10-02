using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

}
