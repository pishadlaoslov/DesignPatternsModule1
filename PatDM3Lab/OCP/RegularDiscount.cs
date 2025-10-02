using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.OCP
{
    public class RegularDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double amount) => amount;
    }
}
