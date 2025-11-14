using System;
using Tyuiu.Ahmadi2.Sprint3.Task6.V15.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ахмади Х. | АСОибу-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Ахмади Хусейн |  АСОибу-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [6, 15] сумму всех делителей                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 6;
            int stopValue = 15;

            Console.WriteLine($"Начало отрезка = {startValue}");
            Console.WriteLine($"Конец отрезка = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Сумма всех делителей = {result}");
            Console.ReadKey();
        }
    }
}