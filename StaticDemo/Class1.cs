using System;

namespace StaticDemo
{
    public class ClassParent
    {
        string a = "50";
        int res;
        public void show()
        {
            Console.WriteLine("Parent Show method");
            bool isTrue = int.TryParse(a, out res);
            Console.WriteLine(res);
        }

        private int total;
        public int MyProperty
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
    }

    static class TestExtention
    {
        public static void Hide(this ClassParent objclass)
        {
            Console.WriteLine("Extention to parent");
        }
    }

    public class Class1 : ClassParent
    {
        public readonly string Name = "Tush";
        public const float PI = 3.14f;
        public Class1(string name)
        {
            Name = name;
            MyProperty = 10;
        }

        public Class1()
        {

        }
        public new void show()
        {
            base.show();
            Console.WriteLine(MyProperty);
        }

        static void Main()
        {
            double c = 37, f = 98.6;
            Console.WriteLine(Convertor.ToCelcius(c));
            Console.WriteLine(Convertor.ToFahrenheit(f));
            ClassParent objParent = new Class1();
            objParent.Hide();
            Class1 obj = new Class1("Read1");
            objParent.show();
            obj.show();
            Console.ReadLine();
        }
    }

    public class abc
    {
        protected internal void InternalPreotectedTest()
        {
            Console.WriteLine("success");
        }
    }
    class pqr : abc
    {
        static void Main()
        {
            pqr abc = new pqr();
            abc.InternalPreotectedTest();
        }
    }

 
}
