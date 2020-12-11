using System;

namespace OopDemo2
{
    class Shape
    {

        private void printColor()
        {
            Console.WriteLine("Color of shape");
        }

        public virtual void Draw()
        {
            Console.WriteLine("Main Draw");
        }

        protected double Area()
        {
            this.printColor();
            double sonuc = 100;
            return sonuc;
        }

        internal void PrintName(string name)
        {
            Console.WriteLine(name);
        }

    }

    class Circle : Shape
    {
        
        public Circle()
        {
            this.Area();
            this.PrintName("merhaba");
        }

        public override void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();

            var shape = new Shape();
            shape.Draw();
        }
    }
}
