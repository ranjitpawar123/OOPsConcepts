using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    interface Interface1
    {
        void Test();
    }

    interface Interface2
    {
        void Test();
    }
    class MultipleInheritanceTest : Interface1, Interface2
    {
        void Interface1.Test()
        {
            Console.WriteLine("hi");
        }
        void Interface2.Test()
        {
            Console.WriteLine("Bye");
        }
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            Interface1 i1 = obj;
            Interface2 i2 = obj;
            i1.Test();
            i2.Test();
            Console.ReadLine();
        }
    }
}
