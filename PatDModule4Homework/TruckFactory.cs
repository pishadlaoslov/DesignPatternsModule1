using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class TruckFactory : VehicleFactory
    {
        private readonly int capacity;
        private readonly int axles;

        public TruckFactory(int capacity, int axles)
        {
            this.capacity = capacity;
            this.axles = axles;
        }

        public override IVehicle CreateVehicle()
        {
            return new Truck(capacity, axles);
        }
    }
}
