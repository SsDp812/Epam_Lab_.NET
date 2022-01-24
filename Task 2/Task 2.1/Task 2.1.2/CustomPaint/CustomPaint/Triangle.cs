using System;
namespace CustomPaint
{
    class Triangle : Figure
    {
        //класс треугольник
        Line side1;
        Line side2;
        Line side3;
        public Triangle(int x, int y, int side1, int side2, int side3) : base(x, y)
        {
            this.side1 = new Line(side1,x,y);
            this.side2 = new Line(side2,x,y);
            this.side3 = new Line(side3,x,y);
        }
        public Triangle() : base()
        {
            Console.Write("---Enter Side1---");
            this.side1 = new Line();
            Console.WriteLine("---Enter Side2---");
            this.side2 = new Line();
            Console.WriteLine("---Enter Side3---");
            this.side3 = new Line();
        }
        public int perimeter
        {
            get { return this.side1.lenght + this.side2.lenght + this.side3.lenght; }
        }
        public double sqr
        {
            get
            {
                int halfper = perimeter / 2;
                return Math.Sqrt(halfper *(halfper - this.side1.lenght)*(halfper - this.side2.lenght)*(halfper - this.side3.lenght));

            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Triangle");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Square: {sqr}");
            Console.WriteLine($"Side1: {side1.lenght}");
            Console.WriteLine($"Side2: {side2.lenght}");
            Console.WriteLine($"Side3: {side3.lenght}");
            Console.WriteLine("--------------------");
        }
    }
}
