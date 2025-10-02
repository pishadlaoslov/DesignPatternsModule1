using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM4Practice
{
    public class ReportCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Report();
        }
    }

    public class ResumeCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Resume();
        }
    }

    public class LetterCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Letter();
        }
    }

    public class InvoiceCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Invoice();
        }
    }

}
