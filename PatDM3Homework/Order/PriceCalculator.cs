using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Homework.Order
{
    public class PriceCalculator
    {
        public double CalculateTotalPrice(Order order)
        {
            return order.Quantity * order.Price * 0.9; // Скидка 10%
        }
    }

}
