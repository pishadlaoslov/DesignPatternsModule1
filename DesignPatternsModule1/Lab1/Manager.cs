using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsModule1.Lab1
{
    public class Manager : Employee
    {
        public double FixedSalary { get; set; }
        public double Bonus { get; set; }

        public Manager(string name, int id, double fixedSalary, double bonus)
            : base(name, id, "Manager")
        {
            FixedSalary = fixedSalary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return FixedSalary + Bonus;
        }
    }
}
