using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.SRP
{
    public class InvoiceCalculator
    {
        public double CalculateTotal(Invoice invoice)
        {
            double subTotal = invoice.Items.Sum(item => item.Price);
            return subTotal + (subTotal * invoice.TaxRate);
        }
    }
}
