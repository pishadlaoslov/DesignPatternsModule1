using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Open_Closed_Principle
{
    public class FreelancerEmployee : Employee
    {
        public FreelancerEmployee(string name, double baseSalary) : base(name, baseSalary) { }

        public override double CalculateSalary()
        {
            return BaseSalary * 1.05;
        }
    }
}
