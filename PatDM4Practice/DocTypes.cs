using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM4Practice
{
    public class Report : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Report document...");
        }
    }

    public class Resume : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Resume document...");
        }
    }

    public class Letter : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Letter document...");
        }
    }

    public class Invoice : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Invoice document...");
        }
    }

}
