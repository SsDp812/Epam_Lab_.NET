using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    public class Map
    {
        public int width;
        public int height;
        public int xCh;
        public int yCh;
        public ElementOfMap[,] arrMap;
        public Character ch;
        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            arrMap = new ElementOfMap[width, height];
            Random rnd = new Random();


            //Создание карты и генерация элементов на ней
            for (int i = 0; i < 4; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new Zombie();
            }
            for (int i = 0; i < 3; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new CrazyZombie();
            }
            for (int i = 0; i < 3; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new Banana();
            }
            for(int i = 0;i < 3; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new Apple();
            }
            /*
            for (int i = 0; i < 3; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new Obstacle();
            }
            */
            // obstacles dont working good yet
            for (int i = 0; i < 3; i++)
            {
                arrMap[rnd.Next(width), rnd.Next(height)] = new Coin();
            }

            //Создание персонажа
            arrMap[0, 0] = new Character();
            ch = (Character)arrMap[0, 0];
            xCh = 0;
            yCh = 0;
        }
        public void printMap()
        {
            //метод для отрисовки карты
            Console.WriteLine(@"
         █───▄▀█▀▀█▀▄▄───▐█──────▄▀█▀▀█▀▄▄
        █───▀─▐▌──▐▌─▀▀──▐█─────▀─▐▌──▐▌─█▀
       ▐▌──────▀▄▄▀──────▐█▄▄──────▀▄▄▀──▐▌
       █────────────────────▀█────────────█
      ▐█─────────────────────█▌───────────█
       █───────────────█▄───▄█────────────█
       ▐▌───────────────▀███▀────────────▐▌
        █──────────▀▄───────────▄▀───────█
         █───────────▀▄▄▄▄▄▄▄▄▄▀────────█
");
            Console.Write("         ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"Wallet: {ch.wallet}$        Health: {ch.health}%");
            Console.ResetColor();
            Console.WriteLine();
            for(int i = 0; i < this.width; i++)
            {
                Console.Write("         ");
                for (int j = 0; j < this.height; j++)
                {
                    if(arrMap[i, j] != null)
                    {
                        switch(arrMap[i, j].icon)
                        {
                            case "B":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "A":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "Z":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "C":
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case "$":
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "+":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "T":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Write($"[{arrMap[i, j].icon}]");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"[ ]");
                    }
                }
                Console.WriteLine();
            }
            PrintRules();
        }

        public void PrintRules()
        {
            //метод для вывода правил
            Console.WriteLine();
            Console.WriteLine("----------------------Rules----------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("--------------- + - its you----------------------");
            Console.WriteLine("------------- A and B - food buffs---------------");
            Console.WriteLine("------- A - Apple - buff 25hp to health----------");
            Console.WriteLine("------ B - Banana - buff 15hp to health----------");
            Console.WriteLine("---------------- Z and C - enemies---------------");
            Console.WriteLine("-------- Z - Zombie - attack with 35hp-----------");
            Console.WriteLine("------- C - Crazy Zombie - attck with 40hp-------");
            Console.WriteLine("------- T - Tree (Obstacle) ---------------------");
            Console.WriteLine("------ Collect 3 coins ($) to win!!!------------");
            Console.WriteLine("-------------------------------------------------");
        }
        public void MoveEnemies()
        {
            //метод для передвижения врагов
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                    if((arrMap[i,j] != null) && (arrMap[i,j].icon =="Z" || arrMap[i, j].icon == "C"))
                    {
                        Random rnd = new Random();
                        int way = rnd.Next(0, 4);
                        switch (way)
                        {
                            case 0:
                                if(i != 0 && arrMap[i - 1,j] == null)
                                {
                                    arrMap[i - 1, j] = arrMap[i, j];
                                    arrMap[i, j] = null;
                                }
                                break;
                            case 1:
                                if (i != width - 1 && arrMap[i + 1, j] == null)
                                {
                                    arrMap[i + 1, j] = arrMap[i, j];
                                    arrMap[i, j] = null;
                                }
                                break;
                            case 2:
                                if (j != 0 && arrMap[i, j - 1] == null)
                                {
                                    arrMap[i, j - 1] = arrMap[i, j];
                                    arrMap[i, j] = null;
                                }
                                break;
                            case 3:
                                if (j != height - 1 && arrMap[i, j + 1] == null)
                                {
                                    arrMap[i, j + 1] = arrMap[i, j];
                                    arrMap[i, j] = null;
                                }
                                break;
                        }
                    }
                }
               
            }
        }


        public void MakeMove()
        {
            //метод для передвижения персонажа
            int xTemp = xCh;
            int yTemp = yCh;
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if(yCh != 0)
                    {
                        xCh -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if(yCh != width - 1)
                    {
                        xCh += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if(xCh != 0)
                    {
                        yCh -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if(xCh != height - 1)
                    {
                        yCh += 1;
                    }
                    break;
            }
            if (arrMap[xCh, yCh] == null)
            {
                arrMap[xTemp, yTemp] = null;
                arrMap[xCh, yCh] = ch;
            }
            if (arrMap[xCh, yCh] != null) { 
            
                if (arrMap[xCh, yCh].icon == "A" || arrMap[xCh, yCh].icon == "B")
                {
                    ch.getBuff((Food)arrMap[xCh, yCh]);
                }
                else if (arrMap[xCh, yCh].icon == "Z" || arrMap[xCh, yCh].icon == "C")
                {
                    ch.health -= ((Enemy)arrMap[xCh, yCh]).force;
                }
                else if (arrMap[xCh, yCh].icon == "$")
                {
                    ch.getCoin();
                }
                if (arrMap[xCh, yCh].icon != "T")
                {
                    arrMap[xTemp, yTemp] = null;
                    arrMap[xCh, yCh] = ch;
                }
            }

            
            
        }            
    }
}
