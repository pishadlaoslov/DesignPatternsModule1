using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM1P1
{
    public class Fleet
    {
        private List<Garage> garages = new List<Garage>();

        public void AddGarage(Garage garage)
        {
            garages.Add(garage);
            Console.WriteLine($"Garage added: {garage.Name}");
        }

        public void RemoveGarage(Garage garage)
        {
            if (garages.Remove(garage))
            {
                Console.WriteLine($"Garage removed: {garage.Name}");
            }
            else
            {
                Console.WriteLine("Garage not found.");
            }
        }

        public Vehicle? FindVehicle(string model)
        {
            foreach (var garage in garages)
            {
                foreach (var vehicle in garage.GetVehicles())
                {
                    if (vehicle.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found: {vehicle} in garage {garage.Name}");
                        return vehicle;
                    }
                }
            }

            Console.WriteLine($"Vehicle with model \"{model}\" not found.");
            return null;
        }

        public void DisplayFleet()
        {
            Console.WriteLine("Fleet Overview:");
            foreach (var garage in garages)
            {
                Console.WriteLine($"- {garage}");
                foreach (var vehicle in garage.GetVehicles())
                {
                    Console.WriteLine($"    • {vehicle}");
                }
            }
        }
    }
}
