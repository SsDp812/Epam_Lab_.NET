using System;
namespace CustomPaint
{
    class Square : Figure
    {
        //класс квадрат
        protected Line side1;
        public Square(int x, int y, int side) : base(x, y)
        {
            this.side1 = new Line(side,x,y);
        }
        public Square() : base()
        {
            Console.WriteLine("---Enter Side1---");
            this.side1 = new Line();
        }

        public int perimeter
        {
            get
            {
                return side1.lenght * 4;
            }
        }
        public int sqr
        {
            get
            {
                return side1.lenght * side1.lenght;
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
            Console.WriteLine($"Side: {side1.lenght}");
            Console.WriteLine("--------------------");
        }
    }
    
}
