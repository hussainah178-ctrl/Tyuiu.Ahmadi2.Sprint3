using System;
using Tyuiu.Ahmadi2.Sprint3.Task5.V18.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ахмади Х. | АСОибу-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ахмади Хусейн |  АСОибу-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму сумм ряда при x=5:                                      *");
            Console.WriteLine("*    3   11                                                               *");
            Console.WriteLine("* y = Σ   Σ  (cos(x) + k²/2)                                              *");
            Console.WriteLine("*   i=1 k=1                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 11;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага первой суммы ряда = {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда = {stopValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда = {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Сумма сумм ряда = {result}");
            Console.ReadKey();
        }
    }
}