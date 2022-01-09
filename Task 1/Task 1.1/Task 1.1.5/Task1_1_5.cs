using System;
namespace Task1_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for(int i = 3; i <= 999; i++)
            {
                if((i % 3 == 0) || (i % 5 == 0))
                {
                    summ += i;
                }
            }
            Console.WriteLine("Answer is {0}",summ);
        }
    }
}