using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM1P1
{
    public class Garage
    {
        public string Name { get; set; }
        private List<Vehicle> vehicles = new List<Vehicle>();

        public Garage(string name)
        {
            Name = name;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"Added: {vehicle} → {Name}");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            if (vehicles.Remove(vehicle))
            {
                Console.WriteLine($"Removed: {vehicle} → {Name}");
            }
            else
            {
                Console.WriteLine($"Vehicle not found in garage {Name}.");
            }
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public override string ToString()
        {
            return $"Garage \"{Name}\" ({vehicles.Count} vehicles)";
        }
    }
}
