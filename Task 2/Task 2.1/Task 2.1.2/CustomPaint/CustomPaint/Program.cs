using System;
using System.Collections.Generic;
namespace CustomPaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string UserName = Console.ReadLine();
            List <Figure> desk = new List <Figure> ();
            Console.WriteLine("Commands: ");
            Console.WriteLine("'figure'(correct name of figure) - add new figure on desk");
            Console.WriteLine("Change user - to choode new userName(not clear desk)");
            Console.WriteLine("Clear - to clear the desk");
            Console.WriteLine("Info - to show info about desk");
            Console.WriteLine("Off - to turn off programm");
            Console.WriteLine("Figures: ");
            Console.WriteLine("Circle, Сircumference, Ring, Line, Rectangle, Square, Triangle");
            bool cond = true;
            while (cond)
            {
                Console.Write($"Dear, {UserName}! Enter command: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Change user":
                        Console.Write("What is your new name? ");
                        UserName = Console.ReadLine();
                        Console.WriteLine("User was changed");
                        break;

                    case "Clear":
                        desk.Clear();
                        Console.WriteLine("Desk was cleared");
                        break;

                    case "Info":
                        if (desk.Count > 0)
                        {
                            foreach (Figure f in desk)
                            {
                                f.showInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Desk is empty");
                        }
                        break;

                    case "Off":
                        cond = false;
                        break;

                    case "Circle":
                        desk.Add(new Circle());
                        break;

                    case "Сircumference":
                        desk.Add(new Сircumference());
                        break;

                    case "Ring":
                        desk.Add(new Ring());
                        break;

                    case "Line":
                        desk.Add(new Line());
                        break;

                    case "Square":
                        desk.Add(new Square());
                        break;

                    case "Rectangle":
                        desk.Add(new Rectangle());
                        break;

                    case "Triangle":
                        desk.Add(new Triangle());
                        break;

                    default:
                        Console.WriteLine("Uncorrect command, try again!");
                        break;
                }
            }

        }
    }
}
