using System;

namespace CustomPaint
{
    class Circle : Сircumference
    {
        //класс Круг
        public Circle(int x, int y, int radius) : base(x, y, radius)
        {
        }
        public Circle() : base()
        {
        }

        public double square
        {
            get
            {
                return this.radius * this.radius * Math.PI;
            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Сircumference");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine($"Square: {square}");
            Console.WriteLine("--------------------");
        }
    }
}
