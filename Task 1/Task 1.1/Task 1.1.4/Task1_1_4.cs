using System;
namespace Task1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int count = 1; count <= N;count++)
            {
                int stars = 1;
                for (int j = 0; j < count; j++)
                {
                    string space = new(' ', N - j - 1);
                    string starsS = new('*', stars);
                    stars += 2;
                    Console.WriteLine(space + starsS);
                }
            }
        }
    }
}