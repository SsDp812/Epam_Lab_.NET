using System;
namespace UpdatedStringClass
{
    public class myString
    {
        private char[] chars;

        //длина строки
        public int lenght
        {
            get
            {
                return chars.Length;
            }
        }

        //myString из String
        public myString(string str)
        {
            chars = str.ToCharArray();
        }

        // myString в String
        public override string ToString() 
        {
            string temp;
            temp = String.Join("", chars);
            return temp;

        }

        //индексатор
        public char this[int index]
        {
            get { return chars[index]; }
            set { chars[index] = value; }
        }

        //поиск индекса первого встреченного символа 
        public  int IndexOf(myString str, char ch)
        {
           for(int i = 0; i < chars.Length; i++){
                if(chars[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }  
        //перегрузка оператора +
        public static myString operator +(myString str1, myString str2)
        {
            char[] tempChars = new char[str1.lenght + str2.lenght];
            int i = 0;
            for (; i < str1.lenght; i++)
            {
                tempChars[i] = str1[i];
            }
            for (int j = i; j < i + str2.lenght; j++)
            {
                tempChars[j] = str2[j - str1.lenght];
            }
            return new myString((new string(tempChars)));
        }

        // перегрузка оператора <
        public static bool operator <(myString str1, myString str2) 
        {
            return (str1.lenght < str2.lenght);
        }
        // перегрузка оператора >
        public static bool operator >(myString str1, myString str2)
        {
            return (str1.lenght > str2.lenght);
        }
        //перегрузка оператора * от себя
        public static myString operator *(myString str1, myString str2)
        {
            return new myString("Maybe you are stupid...");
        }
        //своя функция для создания экзамепляры строки, который хранит ноты
       public static myString makeNotesString()
       {
            return new myString("CDEFGAB");
       }
    }
}
