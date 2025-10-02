using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Interface_Segregation_Principle
{
    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing: " + content);
        }
    }
}
