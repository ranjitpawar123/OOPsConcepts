using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild a = new AbsChild();
            a.Add(12, 12);
            a.Sub(12, 12);

            Console.WriteLine("Enter ShapeCode :");
            string value = Console.ReadLine();

            AbsShapes objShape;
            if (value == "1")
            {
                objShape = new circle("Circle", 10);
            }
            else
            {
                objShape = new Rectangle("Rectangle", 10, 20);
            }

            objShape.GetShape();
            Console.WriteLine("Area : " + objShape.GetArea());
            Console.WriteLine("Parimeter : " + objShape.GetPerimeter());
            Console.ReadKey();
        }
    }

    //abstract class AbsChild : AbsParent
    //{
    //    public abstract void AddNew(int x, int y);

    //    //Abstract method
    //    public abstract void SubNew(int x, int y);

    //}

    //class MultiAbsChild : AbsChild
    //{
    //    public override void Mul(int x, int y)
    //    {
    //        Console.WriteLine(x * y);
    //    }

    //    public override void Div(int x, int y)
    //    {
    //        Console.WriteLine(x / y);
    //    }

    //    public override void AddNew(int x, int y)
    //    {
    //        Console.WriteLine(x * y);
    //    }

    //    public override void SubNew(int x, int y)
    //    {
    //        Console.WriteLine(x / y);
    //    }
    //    static void Main()
    //    {
    //        MultiAbsChild a = new MultiAbsChild();
    //        a.Add(12, 12);
    //        a.Sub(12, 12);
    //        a.AddNew(12, 12);
    //        a.SubNew(12, 12);
    //        Console.ReadLine();
    //    }
    //}


    class NonAbsChild : NonAbsParent
    {
        public sealed override void Show()
        {
            Console.WriteLine("This is child class method");
        }

        static void Main()
        {
            NonAbsChild newObj = new NonAbsChild();
            NonAbsParent newObj1 = new NonAbsChild();
            newObj1.Show();
            newObj.Show();
            Console.ReadLine();
        }
    }

    class NonAbsGrandChild : NonAbsChild
    {
        public new void Show() // We can not ovverride it but can hide
        {
            Console.WriteLine("This is child class method");
        }

        static void Main()
        {
            NonAbsGrandChild newObj = new NonAbsGrandChild();
            NonAbsChild newObj1 = new NonAbsGrandChild();
            newObj1.Show();
            newObj.Show();
            Console.ReadLine();
        }
    }

}
