using System;
namespace CustomPaint
{
    class Square : Figure
    {
        //класс квадрат
        protected int side1;
        public Square(int x, int y, int side) : base(x, y)
        {
            this.side1 = side;
        }
        public Square() : base()
        {
            Console.Write("Enter Side: ");
            this.side1 = int.Parse(Console.ReadLine());
        }

        public int perimeter
        {
            get
            {
                return side1 * 4;
            }
        }
        public int sqr
        {
            get
            {
                return side1 * side1;
            }
        }
        public override void showInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Type: Square");
            Console.WriteLine($"X: {this.xCentre}");
            Console.WriteLine($"Y: {this.yCentre}");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Square: {sqr}");
            Console.WriteLine($"Side: {side1}");
            Console.WriteLine("--------------------");
        }
    }
    
}
