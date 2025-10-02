using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM4Lab
{
    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport(string model, int speed)
            => new Car(model, speed);
    }

    public class MotorcycleFactory : TransportFactory
    {
        public override ITransport CreateTransport(string model, int speed)
            => new Motorcycle(model, speed);
    }

    public class PlaneFactory : TransportFactory
    {
        public override ITransport CreateTransport(string model, int speed)
            => new Plane(model, speed);
    }

    public class BicycleFactory : TransportFactory
    {
        public override ITransport CreateTransport(string model, int speed)
            => new Bicycle(model, speed);
    }

}
