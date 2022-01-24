using System;
namespace CustomPaint
{
    class Line : Figure
    {
        //класс линия
        public int lenght;
        public Line(int len, int x,int y) : base(x,y)
        {
            this.lenght = len;
        }
        public Line() : base()
        {
            Console.Write("Enter Lenght of line: ");
            this.lenght = int.Parse(Console.ReadLine());
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Line");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Lenght: {lenght}");
            Console.WriteLine("--------------------");
        }
    }
}
