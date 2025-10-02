using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM4Lab
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport(string model, int speed);
    }

}
