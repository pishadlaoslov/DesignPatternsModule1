using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsModule1.Lab1
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Position { get; set; }

        public Employee(string name, int id, string position)
        {
            Name = name;
            Id = id;
            Position = position;
        }

        public virtual double CalculateSalary()
        {
            return 0.0;
        }
        
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {CalculateSalary():C2}";
        }
    }
}
