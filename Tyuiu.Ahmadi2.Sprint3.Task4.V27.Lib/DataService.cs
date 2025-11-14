using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task4.V27.Lib
{
    public class DataService :ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            int x = startValue;

            do
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }

                double denominator = Math.Cos(x) + Math.Sin(x);

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001)
                {
                    x++;
                    continue;
                }

                double y = x / denominator;
                sum += y;
                x++;
            }
            while (x <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}