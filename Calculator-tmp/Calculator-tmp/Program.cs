using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {

            int NumberStart;

            int firstNum;
            int secondNum;
            int result;

            Console.WriteLine("Выберите опреацию которую хотите сделать:");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести первое на второе");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 % из числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");



            do
            {

                NumberStart = Convert.ToInt32(Console.ReadLine());

                if (NumberStart == 1)
                {

                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    result = firstNum + secondNum;

                    Console.WriteLine(result);
                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 2)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    result = firstNum - secondNum;

                    Console.WriteLine(result);
                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 3)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    result = firstNum * secondNum;

                    Console.WriteLine(result);
                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 4)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    if (secondNum == 0)
                    {
                        Console.WriteLine("Недопустимое значений, введите второе число заново");
                        secondNum = Convert.ToInt32(Console.ReadLine());
                    }

                    result = firstNum / secondNum;

                    Console.WriteLine(result);
                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 5)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение степени:");
                    secondNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Pow(firstNum, secondNum));

                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 6)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Sqrt(firstNum));
                    Console.WriteLine("Введите операцию ещё раз:");
                }

                if (NumberStart == 7)
                {

                    Console.WriteLine("Введите первое число:");
                    double doublefirstNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(doublefirstNum * 1 / 100);

                    Console.WriteLine("Введите операцию ещё раз:");
                }
                if (NumberStart == 8)
                {
                    Console.WriteLine("Введите первое число:");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    result = 1;

                    for (int i = 1; i <= firstNum; i++)
                    {
                        result *= i;
                    }


                    Console.WriteLine(result);
                    Console.WriteLine("Введите операцию ещё раз:");
                }
                if (NumberStart == 9)
                {
                    break;
                }



            } while (NumberStart != 9);

        }
    }
}