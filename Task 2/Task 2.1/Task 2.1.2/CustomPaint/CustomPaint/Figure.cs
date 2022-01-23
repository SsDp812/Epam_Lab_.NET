using System;
namespace CustomPaint
{
    abstract class Figure
    {
        //абстрактный класс фигура
        protected int xCentre { get; set; }
        protected int yCentre { get; set; }
        public Figure(int x, int y)
        {
            this.xCentre = x;
            this.yCentre = y;
        }
        public Figure()
        {
            Console.Write("Eneter X: ");
            this.xCentre = int.Parse(Console.ReadLine());
            Console.Write("Eneter Y: ");
            this.yCentre = int.Parse(Console.ReadLine());
        }
        public abstract void showInfo();
    }
}
