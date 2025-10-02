using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsModule1
{
    public class Worker : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Worker(string name, int id, double hourlyRate, int hoursWorked)
            : base(name, id, "Worker")
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
