using System;
using System.Collections.Generic;
namespace Task1_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxArrSize = 5;
            int maxArrValue = 20;
            int[,,] arr = new int[rnd.Next(maxArrSize),rnd.Next(maxArrSize),rnd.Next(maxArrSize)];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(maxArrValue);
                        if((rnd.Next(10) % 2) == 0)
                        {
                            arr[i, j, k] = -1 * arr[i, j, k];
                            //random generating negative numbers
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if(arr[i, j, k] < 0)
                        {
                            arr[i,j,k] = 0;
                        }
                    }
                }
            }

        }
        
    }
}