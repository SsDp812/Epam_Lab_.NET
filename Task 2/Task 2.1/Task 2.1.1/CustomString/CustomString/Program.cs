using System;
using UpdatedStringClass;
namespace CustomString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myString str = new myString("Hello World!");
            Console.WriteLine(str.ToString());
            myString str2 = new myString("Hello Everyone!");
            str += str2;
            Console.WriteLine(str.ToString());
            Console.WriteLine(str > str2);
            Console.WriteLine(str < str2);
            Console.WriteLine((str * str2).ToString());
            myString notes = myString.makeNotesString();
            for(int i = 0; i < notes.lenght; i++)
            {
                Console.WriteLine(notes[i]);
            }
        }
    }
}
