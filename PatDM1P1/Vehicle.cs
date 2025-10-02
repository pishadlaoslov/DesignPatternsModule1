using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM1P1
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{ToString()} – Engine started.");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine($"{ToString()} – Engine stopped.");
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }
}
