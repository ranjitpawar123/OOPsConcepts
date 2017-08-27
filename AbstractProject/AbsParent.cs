using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class AbsParent
    {
        //Non-abstract method
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        //Non-abstract method
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        //Abstract method
        public abstract void Mul(int x, int y);

        //Abstract method
        public abstract void Div(int x, int y);
    }

    class NonAbsParent
    {
        public virtual void Show()
        {
            Console.WriteLine("This is parent class method");
        }

        public void Print()
        {
            Console.WriteLine("This is parent class method");
        }

    }
}
