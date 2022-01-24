using System;
namespace CustomPaint
{
    class Rectangle : Square
    {
        //класс прямоугольник
        Line side2;
        public Rectangle(int x, int y, int side1, int side2) : base(x, y, side1)
        {
            Console.WriteLine("---Enter Side2---");
            this.side2 = new Line(x, y, side2);
        }
        public Rectangle() : base()
        {
            this.side2 = new Line();
        }
        public new int sqr
        {
            get { return side1.lenght * side2.lenght; }
        }
        public new int perimeter
        {
            get { return ((side1.lenght + side2.lenght) * 2); }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Rectangle");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Square: {sqr}");
            Console.WriteLine($"Side1: {side1.lenght}");
            Console.WriteLine($"Side2: {side2.lenght}");
            Console.WriteLine("--------------------");
        }
    }
    
}
