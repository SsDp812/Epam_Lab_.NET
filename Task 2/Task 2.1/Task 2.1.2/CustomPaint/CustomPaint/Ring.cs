using System;
namespace CustomPaint
{
    class Ring : Figure
    {
        Circle circle1;
        Circle circle2;
        public Ring() : base()
        {
            Console.WriteLine("---Inner Circle---");
            Console.Write("Enter Radius: ");
            this.circle1 = new Circle(this.xCentre, this.yCentre,int.Parse(Console.ReadLine()));
            Console.WriteLine("---Outer Circle---");
            Console.Write("Enter Radius: ");
            this.circle2 = new Circle(this.xCentre, this.yCentre, int.Parse(Console.ReadLine()));
        }
        public Ring(int x, int y, int rad1, int rad2) : base(x, y)
        {
            this.circle1 = new Circle(x,y,rad1);
            this.circle2 = new Circle(x,y,rad2);
        }
        public double square
        {
            get
            {
                return this.circle2.square - this.circle1.square;
            }
        }
        public double lenght
        {
            get
            {
                return this.circle1.lenght + this.circle2.lenght;
            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Ring");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"X: {this.yCentre}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine($"Square: {square}");
            Console.WriteLine("--------------------");
        }
    }
}
