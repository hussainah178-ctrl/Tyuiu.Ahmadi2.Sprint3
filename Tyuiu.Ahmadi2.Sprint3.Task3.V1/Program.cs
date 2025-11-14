using System;
using Tyuiu.Ahmadi2.Sprint3.Task3.V1.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ахмади Х. | АСОибу-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Ахмади Хусейн |АСОибу-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'a' в строке:         *");
            Console.WriteLine("* 'have a nice time'                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "have a nice time";
            char chr = 'a';

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Искомый символ: {chr}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetCharCount(str, chr);

            Console.WriteLine($"Количество символов '{chr}' в строке = {result}");
            Console.ReadKey();
        }
    }
}