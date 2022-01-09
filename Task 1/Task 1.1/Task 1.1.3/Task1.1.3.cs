using System;
namespace Task1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Console.Write(new String(' ', N - i));
                Console.WriteLine(new String('*',i * 2 - 1));
            }
        }
 
    }
}