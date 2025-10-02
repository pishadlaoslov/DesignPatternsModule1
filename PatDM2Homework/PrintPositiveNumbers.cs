using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM2Homework
{
    public class NumberPrinter
    {
        public void PrintPositiveNumbers(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public int Divide(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;
        }

    }
}
