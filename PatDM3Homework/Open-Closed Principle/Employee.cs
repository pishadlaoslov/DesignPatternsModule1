using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Open_Closed_Principle
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract double CalculateSalary();
    }
}
