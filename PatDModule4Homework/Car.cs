using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class Car : IVehicle
    {
        public string Brand { get; }
        public string Model { get; }
        public string FuelType { get; }

        public Car(string brand, string model, string fuelType)
        {
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }

        public void Drive() => Console.WriteLine($"{Brand} {Model} is driving.");
        public void Refuel() => Console.WriteLine($"Refueling {Brand} {Model} with {FuelType}.");
    }
}
