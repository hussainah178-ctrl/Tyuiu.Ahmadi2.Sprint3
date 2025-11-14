using System;
using Tyuiu.Ahmadi2.Sprint3.Task7.V4.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Ахмади Х. | АСОибу-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Ахмади Хусейн | АСОибу-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = (2x+6)/(cos(x)+x) - 3                                           *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль.   *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                       *");
            Console.WriteLine("* Значения занести в массив!                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            for (int i = 0; i < valueArray.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine("|{0,5:d}     | {1,8:f2}  |", x, valueArray[i]);
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}