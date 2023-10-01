using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Progi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool IsDone = true;

            while (IsDone != false)
            {

                Menu();
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        guess_number();
                        IsDone = true;
                        break;

                    case 2:
                        tableymnoz();
                        IsDone = true;
                        break;

                    case 3:
                        delitel();
                        Console.WriteLine("");
                        IsDone = true;
                        break;

                    case 9:
                        IsDone = false;
                        break;

                }
            }
        }


        static void Menu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Игра 'Угадай число'");
            Console.WriteLine("2 - Таблица умножения ");
            Console.WriteLine("3 - Вывод делителей числа");
            Console.WriteLine("9 - Выход");

        }

        static void guess_number()
        {
            Random rnd = new Random();

            int value = rnd.Next(0, 100);
            Console.WriteLine("Я загадал число от 0 до 100, попробуй отгадать");
            int answer = Convert.ToInt32(Console.ReadLine());

            bool Guesse_Done = true;
            while (Guesse_Done != false)
            {
                if (answer < value)
                {
                    Console.WriteLine("Надо больше!");
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                if (answer > value)
                {
                    Console.WriteLine("Надо меньше!");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                if (answer == value)
                {
                    Console.WriteLine("Правильно!");
                    Guesse_Done = false;
                }

            }


        }

        static void tableymnoz()
        {
            Int32[,] table = new int[10, 10];


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    table[i, j] = i * j;
                }
                Console.WriteLine();
            }


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0, 3}", table[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void delitel()
        {


            Console.WriteLine("Введите число: ");
            Console.WriteLine("Для выхода введите 0");

            bool exit_done = true;

            while (exit_done != false)
            {
                Console.WriteLine("");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 0)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.Write(i + "\t");
                        }

                        exit_done = true;
                    }
                } else
                {
                    exit_done= false;
                    break;
                }
                    



            }

            }
        }
    }
