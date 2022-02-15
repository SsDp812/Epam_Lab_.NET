using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3._1._2
{
    public class Word
    {
        public int count;
        public string text;
        public Word(int count, string text)
        {
            this.count = count;
            this.text = text;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            char[] text = Console.ReadLine().ToCharArray();
            string correctText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            Console.WriteLine(correctText);
            
            string[] arr = correctText.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].ToLower();
            }
            Array.Sort(arr);
            List<Word> words = new List<Word>();
            for (int i = 0;i < arr.Length; i++)
            {
                int count = 1;
                if (i + 1 != arr.Length)
                {
                    int j = i;
                    while (arr[j + 1] == arr[i])
                    {
                        count++;
                        j++;
                    }
                }

                words.Add(new Word(count, arr[i]));
                i += (count - 1);
                
            }
            foreach(var item in words)
            {
                Console.WriteLine($"'{item.text}' встречается {item.count} раз");
            }
        }
    }
}
