using System;

namespace CustomPaint
{
    class Сircumference : Figure
    {
        protected int radius { get; set; }
        public Сircumference(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        public Сircumference() : base()
        {
            Console.Write("Enter Radius: ");
            this.radius = int.Parse(Console.ReadLine());
        }
        public double lenght
        {
            get
            {
                return this.radius * Math.PI * 2;
            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Сircumference");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"X: {this.yCentre}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine("--------------------");
        }
    }
}
