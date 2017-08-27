using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class AbsShapes
    {
        public double width, height, redius;
        public const double pi = 3.14;
        public string Shape;
       
        public abstract double GetArea();

        public abstract double GetPerimeter();
                
        public void GetShape()
        {
            Console.WriteLine(Shape.ToString());
        }

    }

    class circle : AbsShapes
    {
        //double radiusValue;
        public circle(string Shape, double redius)
        {
            this.redius = redius;
            this.Shape = Shape;
        }
        public override double GetArea()
        {
            return pi * redius * redius;

        }

        public override double GetPerimeter()
        {
            return 2 * pi * redius;

        }

    }

    class Rectangle : AbsShapes
    {
        //double radiusValue;
        public Rectangle(string shape,double height,double width)
        {
            this.height = height;
            base.width = width;
            this.Shape = shape;
        }
        public override double GetArea()
        {
            return height * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (height + width);

        }
    }

    //class Shapeclient
    //{
    //    public static void main(string[] args)
    //    {
    //        AbsShapes objShape;
    //        if (args[0] == "1")
    //        {
    //            objShape = new circle("Circle", 10);
    //        }
    //        else
    //        {
    //            objShape = new Rectangle("Rectangle", 10, 20);
    //        }

    //        objShape.GetShape();
    //        Console.WriteLine(objShape.GetArea());
    //        Console.WriteLine(objShape.GetPerimeter());

    //    }

    //}


}
