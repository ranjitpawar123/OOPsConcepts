using System;
using StaticDemo;

namespace AbstractProject
{
    class TestInterfaceChild : abc, ITestInterfaceParent
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main()
        {
            TestInterfaceChild obj = new TestInterfaceChild();
            obj.Add(10, 20);
            obj.Add(10, 20, 30);
            obj.Sub(10, 20);
            obj.InternalPreotectedTest();
            Console.ReadLine();
        }
    }

    class newclass : TestInterfaceChild
    {
        static void Main()
        {
            newclass a = new newclass();
            a.InternalPreotectedTest();
        }
    }
}
