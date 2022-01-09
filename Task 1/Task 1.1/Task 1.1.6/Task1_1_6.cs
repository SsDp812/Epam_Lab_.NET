using System;
using System.Collections.Generic;
namespace Task1_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> info = new SortedList<int,string>();
            while (true)
            {
                Console.Write("Параметры надписи: ");
                if(info.Count == 0)
                {
                    Console.Write("None");
                }
                else
                {
                    foreach(var option in info)
                    {
                        Console.Write(option.Value);
                        if(option.Key != info.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("    1: bold");
                Console.WriteLine("    1: italic");
                Console.WriteLine("    1: underline");
                Console.Write("Введите: ");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        if (info.ContainsKey(1)){
                            info.Remove(1);
                        }
                        else
                        {
                            info.Add(1,"bold");
                        }
                        break;

                    case "2":
                        if (info.ContainsKey(2))
                        {
                            info.Remove(2);
                        }
                        else
                        {
                            info.Add(2,"italic");
                        }
                        break;

                    case "3":
                        if (info.ContainsKey(3))
                        {
                            info.Remove(3);
                        }
                        else
                        {
                            info.Add(3,"underline");
                        }
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            
        }
    }
}