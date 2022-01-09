using System;
namespace Task1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string1: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("input string2: ");
            string string2 = Console.ReadLine();
            string newString = "";
            foreach (char ch in string1)
            {
                if (string2.Contains(ch))
                {
                    newString += ch;
                    newString += ch;
                }
                else
                {
                    newString += ch;
                }
            }
            string2 = newString;
            Console.WriteLine($"New-String: {string2}");
        }
    }
}