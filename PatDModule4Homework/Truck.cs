using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class Truck : IVehicle
    {
        public int Capacity { get; }
        public int Axles { get; }

        public Truck(int capacity, int axles)
        {
            Capacity = capacity;
            Axles = axles;
        }

        public void Drive() => Console.WriteLine($"Truck with {Axles} axles is transporting goods.");
        public void Refuel() => Console.WriteLine($"Refueling truck with capacity of {Capacity} tons.");
    }
}
