using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.DIP
{
    public class SmsService : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
