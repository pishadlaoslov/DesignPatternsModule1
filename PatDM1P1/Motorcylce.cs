using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM1P1
{
    public class Motorcycle : Vehicle
    {
        public string BodyType { get; set; }
        public bool HasBox { get; set; }

        public Motorcycle(string make, string model, int year, string bodyType, bool hasBox)
            : base(make, model, year)
        {
            BodyType = bodyType;
            HasBox = hasBox;
        }

        public override string ToString()
        {
            return base.ToString() + $" (Motorcycle, Body: {BodyType}, Box: {(HasBox ? "Yes" : "No")})";
        }
    }
}
