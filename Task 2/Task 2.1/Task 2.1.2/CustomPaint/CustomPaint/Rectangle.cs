using System;
namespace CustomPaint
{
    class Rectangle : Square
    {
        //класс прямоугольник
        int side2;
        public Rectangle(int x, int y, int side1, int side2) : base(x, y, side1)
        {
            this.side2 = side2;
        }
        public Rectangle() : base()
        {
            Console.Write("Side2: ");
            this.side2 = int.Parse(Console.ReadLine());
        }
        public new int sqr
        {
            get { return side1 * side2; }
        }
        public new int perimeter
        {
            get { return ((side1 + side2) * 2); }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Rectangle");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Square: {sqr}");
            Console.WriteLine($"Side1: {side1}");
            Console.WriteLine($"Side1: {side2}");
            Console.WriteLine("--------------------");
        }
    }
    
}
