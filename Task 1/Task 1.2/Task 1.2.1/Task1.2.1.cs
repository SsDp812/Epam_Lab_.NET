using System;
using System.Collections.Generic;
using System.Text;
namespace Task1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text: ");
            char[] text = Console.ReadLine().ToCharArray();
            string correctText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] arr = correctText.Split(' ');
            int summ = 0;
            foreach(string s in arr)
            {
                summ += s.Length;
            }
            Console.WriteLine("Answer is {0}", (int)(summ / arr.Length));
            //answer was rounded
        }
        
    }
}