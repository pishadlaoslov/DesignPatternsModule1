using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.ISP
{
    public class HumanWorker : IWorkable, IEatable, ISleepable
    {
        public void Work() => Console.WriteLine("Working");
        public void Eat() => Console.WriteLine("Eating");
        public void Sleep() => Console.WriteLine("Sleeping");
    }
}
