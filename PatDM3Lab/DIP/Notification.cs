using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.DIP
{
    public class Notification
    {
        private readonly IMessageSender _messageSender;

        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Send(string message)
        {
            _messageSender.Send(message);
        }
    }
}
