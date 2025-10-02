using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.SRP
{
    public class Invoice
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public double TaxRate { get; set; }
    }
}
