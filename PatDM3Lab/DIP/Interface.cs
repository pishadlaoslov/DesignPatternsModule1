using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.DIP
{
    public interface IMessageSender
    {
        void Send(string message);
    }

}
