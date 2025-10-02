using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    internal class CarFactory : VehicleFactory
    {
        private readonly string brand, model, fuelType;

        public CarFactory(string brand, string model, string fuelType)
        {
            this.brand = brand;
            this.model = model;
            this.fuelType = fuelType;
        }

        public override IVehicle CreateVehicle()
        {
            return new Car(brand, model, fuelType);
        }
    }
}
