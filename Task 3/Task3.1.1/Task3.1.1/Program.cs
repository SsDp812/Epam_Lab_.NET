using System;
using System.Collections.Generic;

namespace Task3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько людей в кругу?: ");
            int countOfPeople = int.Parse(Console.ReadLine()); 
            List<string> people = new List<string>();
            for(int i = 0;i < countOfPeople; i++)
            {
                Console.Write($"Имя {i + 1}го: ");
                people.Add(Console.ReadLine());
            }
            Console.Write("Будем вычеркивать каждого: ");
            int N = countOfPeople + 1;
            while (N > people.Count || N == 0)
            {
                Console.Write("Будем вычеркивать каждого: ");
                N = int.Parse(Console.ReadLine());
                if(N > people.Count)
                {
                    Console.WriteLine("Число больше чем количество человек в кругу!");
                }
                else if(N == 0)
                {
                    Console.WriteLine("0 некорректное число!");
                }
            }
            Console.WriteLine("Игра началась");
            int round = 1;
            while(N <= people.Count)
            {
                Console.WriteLine($"Раунд {round}. {people[N-1]} вычеркнут.Людей осталось {people.Count - 1}");
                people.Remove(people[N-1]);
                round++;
            }
            Console.WriteLine($"Игра завершена. Осталось {people.Count} людей");
            Console.WriteLine("Победители: ");
            foreach(string man in people)
            {
                Console.WriteLine(man);
            }
        }
    }
}
