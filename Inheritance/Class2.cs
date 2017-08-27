using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Class2 : Class1
    {
        Class2()
        {
            Console.WriteLine("Class 2 constructor is called.");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            Class2 c2 = new Class2();
            c2.Test1();
            c2.Test2();
            c2.Test3();
            Console.ReadLine();
        }
    }
}
