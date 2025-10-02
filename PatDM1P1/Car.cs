using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM1P1
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public string Transmission { get; set; }

        public Car(string make, string model, int year, int doorCount, string transmission)
            : base(make, model, year)
        {
            DoorCount = doorCount;
            Transmission = transmission;
        }

        public override string ToString()
        {
            return base.ToString() + $" (Car, {DoorCount} doors, Transmission: {Transmission})";
        }
    }
}
