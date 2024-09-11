using System;

namespace Inheritance_lab
{
    public class Shape
    {
       public  Shape(int n1 , int n2)
        {
            Console.WriteLine("Shape Constructor");
            Console.WriteLine("The Tow numbers in Shape is {0} and {1} ", n1 ,  n2);
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Hello from The Grandfather Shape Class");
        }

    }

     public class Box : Shape
    {
        public Box() : base(1,3)
        {
            Console.WriteLine("Shape Child Box Constructor");
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello from the Father Box Class");
        }
    }
    
    public class Rectangle : Box
    {
        public Rectangle()
        {
            Console.WriteLine("Shape Grand son Reactangle Constructor");
        }
        public override void SayHello()
        {
            Console.WriteLine("Hello from The Grandson  Rectangle Class");
        }
    }


    public class Program
    {

        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(1,5);
            shapes[1] = new Box();
            shapes[2] = new Rectangle();

            foreach (Shape e in shapes)
            {
                
            }
        }
    }
}
