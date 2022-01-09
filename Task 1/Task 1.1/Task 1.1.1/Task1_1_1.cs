using System;
namespace Task1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Square of rectangle = {0}", Rectangle(correctUserInput("A"), correctUserInput("B")));
        }
        static int Rectangle(int a, int b)
        {
            return a * b;
        }
        static int correctUserInput(string sideName)
        {
            bool correct = false, converting = false; ;
            double number = 0;
            while (!correct)
            {
                Console.Write("{0}: ", sideName);
                string userInput = Console.ReadLine();
                try
                {
                    number = Convert.ToDouble(userInput);
                    if(number > 0)
                    {
                        correct = true;
                    }
                    else if(number <= 0 && (number % 1 == 0))
                    {
                        Console.WriteLine("Side must me > 0");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return (int)number;
        }
        
    }
}