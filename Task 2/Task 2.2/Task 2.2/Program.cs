using System;

namespace Task_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 40);
            Map mp = new Map(14, 10);
            mp.printMap();
            bool cond = true;
            while (cond)
            {
                mp.MakeMove();
                mp.MoveEnemies();
                Console.Clear();
                mp.printMap();
                string win = mp.ch.checkWinOrLoose();
                switch (win)
                {
                    case "win":
                        Console.Clear();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("You are win!!!");
                        }
                        cond = false;
                        break;
                    case "loose":
                        Console.Clear();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("You are loose((((((");
                        }
                        cond = false;
                        break;
                }
            }
        }
    }
}
