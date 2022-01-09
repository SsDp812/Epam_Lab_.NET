using System;
namespace Task1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string input = Console.ReadLine();
            char[] separators = { ' ', ',', '.', '!', '?', ':', '-' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (word == word.ToLower())
                    count += 1;
            }
            Console.WriteLine($"Count: {count}");
        }
    }
}