using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM2L1
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine($"{this.GetType().Name} is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"{this.GetType().Name} is stopping");
        }
    }

    public class Car : Vehicle { }

    public class Truck : Vehicle { }
}
