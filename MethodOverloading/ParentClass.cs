using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class ParentClass
    {
        public void Test()
        {
            Console.WriteLine("Test 1");
        }

        public void Test(int i)
        {
            Console.WriteLine("Test 2" + i);
        }

        public void Test(string s)
        {
            Console.WriteLine("Test 3" + s);
        }

        public void Test(string s, int i)
        {
            Console.WriteLine("Test 4" + s, i);
        }

        public void Test(int i, string s)
        {
            Console.WriteLine("Test 5" + i, s);
        }
    }
    public class ChildClass : ParentClass
    {
        static void Main()
        {
            ChildClass c = new ChildClass();
            c.Test();
            c.Test(10);
            c.Test("Ranjit");
            c.Test(10,"Ranjit");
            c.Test("Ranjit",10);
            Console.ReadLine();
        }
    }
}
