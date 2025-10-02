using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.DIP
{
    public class EmailService : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
