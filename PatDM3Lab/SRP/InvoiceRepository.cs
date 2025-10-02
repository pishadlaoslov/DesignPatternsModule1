using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.SRP
{
    public class InvoiceRepository
    {
        public void SaveToDatabase(Invoice invoice)
        {
            
            Console.WriteLine($"Invoice #{invoice.Id} saved to database.");
        }
    }
}
