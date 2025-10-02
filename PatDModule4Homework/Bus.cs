using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class Bus : IVehicle
    {
        public int PassengerCapacity { get; }

        public Bus(int passengerCapacity)
        {
            PassengerCapacity = passengerCapacity;
        }

        public void Drive() => Console.WriteLine($"Bus with {PassengerCapacity} seats is moving.");
        public void Refuel() => Console.WriteLine($"Refueling bus for {PassengerCapacity} passengers.");
    }

    public class BusFactory : VehicleFactory
    {
        private readonly int passengerCapacity;

        public BusFactory(int passengerCapacity)
        {
            this.passengerCapacity = passengerCapacity;
        }

        public override IVehicle CreateVehicle()
        {
            return new Bus(passengerCapacity);
        }
    }
}
