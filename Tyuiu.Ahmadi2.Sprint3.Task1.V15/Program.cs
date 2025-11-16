using System;
using Tyuiu.Ahmadi2.Sprint3.Task1.V15.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task1.V15
{
    class Program
    { 
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}