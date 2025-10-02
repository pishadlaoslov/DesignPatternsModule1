using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Practice
{
    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double total) => total;
    }

    public class PercentageDiscount : IDiscount
    {
        private readonly double _percent;

        public PercentageDiscount(double percent)
        {
            _percent = percent;
        }

        public double ApplyDiscount(double total)
        {
            return total * (1 - _percent / 100);
        }
    }

    public class FixedDiscount : IDiscount
    {
        private readonly double _amount;

        public FixedDiscount(double amount)
        {
            _amount = amount;
        }

        public double ApplyDiscount(double total)
        {
            return Math.Max(0, total - _amount);
        }
    }

}
