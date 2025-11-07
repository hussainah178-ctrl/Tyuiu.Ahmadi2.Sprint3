using System;
using Tyulu.Ahmadi2.Sprint3.Task1.V15.Lib;

namespace Tyulu.Ahmadi2.Sprint3.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 2;
            int start = 1;
            int stop = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение X = {x}");
            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(x, start, stop);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}