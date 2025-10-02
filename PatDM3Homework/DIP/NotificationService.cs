using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.DIP
{
    public class NotificationService
    {
        private readonly List<IMessageSender> _senders;

        public NotificationService(List<IMessageSender> senders)
        {
            _senders = senders;
        }

        public void SendNotification(string message)
        {
            foreach (var sender in _senders)
            {
                sender.Send(message);
            }
        }
        
    }
}
