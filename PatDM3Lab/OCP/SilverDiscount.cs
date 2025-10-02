using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.OCP
{
    public class SilverDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount * 0.9;
    }
}
