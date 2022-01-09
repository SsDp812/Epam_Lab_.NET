using System;
using System.Collections.Generic;
namespace Task1_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxArrSize = 8;
            int maxArrValue = 20;
            int[] arr = new int[rnd.Next(1,maxArrSize)];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(maxArrValue);
                if ((rnd.Next(10) % 2) == 0)
                {
                    arr[i] = -1 * arr[i];
                    //random generating negative numbers
                }
                Console.Write("{0}{1}",arr[i],'\t');
            }
            Console.WriteLine();
            int summ = 0;
            foreach(int number in arr)
            {
                if(number > 0)
                {
                    summ += number;
                }
            }
            Console.WriteLine("Summ non-negative numbers is {0}",summ);
        }
        
    }
}