using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM3Lab.ISP
{
    public class RobotWorker : IWorkable
    {
        public void Work() => Console.WriteLine("Robot working");
    }
}
