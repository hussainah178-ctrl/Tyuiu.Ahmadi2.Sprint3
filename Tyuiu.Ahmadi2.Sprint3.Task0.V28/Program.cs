using System;
using Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 0.25;
            Console.WriteLine($"X = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result =  ds.GetMultiplySeries(x);

            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}