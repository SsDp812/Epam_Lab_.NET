using System;
namespace CustomPaint
{
    class Triangle : Figure
    {
        int side1;
        int side2;
        int side3;
        public Triangle(int x, int y, int side1, int side2, int side3) : base(x, y)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public Triangle() : base()
        {
            Console.Write("Enter Side1: ");
            this.side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Side2: ");
            this.side2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Side3: ");
            this.side3 = int.Parse(Console.ReadLine());
        }
        public int perimeter
        {
            get { return this.side1 + this.side2 + this.side3; }
        }
        public double sqr
        {
            get
            {
                int halfper = perimeter / 2;
                return Math.Sqrt(halfper *(halfper - this.side1)*(halfper - this.side2)*(halfper - this.side3));

            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Triangle");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"X: {this.yCentre}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Square: {sqr}");
            Console.WriteLine($"Side1: {side1}");
            Console.WriteLine($"Side1: {side2}");
            Console.WriteLine($"Side1: {side3}");
            Console.WriteLine("--------------------");
        }
    }
}
