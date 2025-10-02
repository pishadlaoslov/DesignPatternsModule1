using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.OCP
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double amount);
    }

}
