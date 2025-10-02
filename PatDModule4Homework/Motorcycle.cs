using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDModule4Homework
{
    public class Motorcycle : IVehicle
    {
        public string Type { get; }
        public int EngineVolume { get; }

        public Motorcycle(string type, int engineVolume)
        {
            Type = type;
            EngineVolume = engineVolume;
        }

        public void Drive() => Console.WriteLine($"The {Type} motorcycle is riding.");
        public void Refuel() => Console.WriteLine($"Refueling {Type} motorcycle with {EngineVolume}cc engine.");
    }
}
