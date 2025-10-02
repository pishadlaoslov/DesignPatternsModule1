using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsModule1
{
    internal class EmployeeManagment
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DisplayAllSalaries()
        {
            Console.WriteLine("List of employees and their salary:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
