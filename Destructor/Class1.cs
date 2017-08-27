using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class DemoDestructor
    {
        public DemoDestructor()
        {
            Console.WriteLine("Created");
        }

        ~DemoDestructor()
        {
            Console.WriteLine("Destroyed");
            Console.ReadLine();
        }

        static void Main()
        {
            DemoDestructor a1 = new DemoDestructor();
            DemoDestructor a2 = new DemoDestructor();
            a1 = null;
            GC.Collect();
            Console.ReadLine();
        }
    }
}
