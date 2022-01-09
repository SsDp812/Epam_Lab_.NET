using System;
namespace Task1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string punct = "?,!.";
            Console.WriteLine("Input string: ");
            string string1 = Console.ReadLine();
            string newString = "";
            newString += char.ToUpper(string1[0]);
            for(int i = 1; i < string1.Length; i++)
            {
                if (punct.Contains(string1[i]) && i != string1.Length)
                {
                    newString += string1[i];
                    newString += " ";
                    newString += char.ToUpper(string1[i + 2]);
                    i += 2;
                }
                else
                {
                    newString += string1[i];
                }
            }
            Console.WriteLine($"New string: {newString}");
        }


    }
}