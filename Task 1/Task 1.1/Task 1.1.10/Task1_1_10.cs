using System;
using System.Collections.Generic;
namespace Task1_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxArrSize = 8;
            int maxArrValue = 20;
            int[,] arr = new int[rnd.Next(2,maxArrSize), rnd.Next(2, maxArrSize)];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(maxArrValue);
                    Console.Write("{0}{1}", arr[i,j], '\t');
                }
                Console.WriteLine();
            }
            int answer = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if((i % 2 == 0) && (j % 2 == 0))
                    {
                        answer += arr[i,j];
                    }
                }
            }
            Console.WriteLine("Answer is {0}", answer);

        }
        
    }
}