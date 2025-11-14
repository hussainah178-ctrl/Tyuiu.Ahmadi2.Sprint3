using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 2 * x + 6;
                    double value = (numerator / denominator) - 3;
                    valueArray[count] = Math.Round(value, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}