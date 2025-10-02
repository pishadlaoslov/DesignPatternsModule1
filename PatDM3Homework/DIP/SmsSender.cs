using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.DIP
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
}
