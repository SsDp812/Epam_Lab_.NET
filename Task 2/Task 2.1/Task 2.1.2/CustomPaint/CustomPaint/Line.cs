using System;
namespace CustomPaint
{
    class Line : Figure
    {
        protected int lenght;
        public Line(int len, int x,int y) : base(x,y)
        {
            this.lenght = len;
        }
        public Line() : base()
        {
            Console.Write("Enter Lenght: ");
            this.lenght = int.Parse(Console.ReadLine());
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Line");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"X: {this.yCentre}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine("--------------------");
        }
    }
}
