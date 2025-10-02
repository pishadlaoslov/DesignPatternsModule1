using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class MotorcycleFactory : VehicleFactory
    {
        private readonly string type;
        private readonly int engineVolume;

        public MotorcycleFactory(string type, int engineVolume)
        {
            this.type = type;
            this.engineVolume = engineVolume;
        }

        public override IVehicle CreateVehicle()
        {
            return new Motorcycle(type, engineVolume);
        }
    }
}
