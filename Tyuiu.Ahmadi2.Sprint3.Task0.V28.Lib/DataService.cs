using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double x)
        {
            double p = 1;

            for (int i = 1; i <= 17; i++)
            {
                p *= Math.Pow(x, i + 2);
            }

            return p;
        }

        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                p *= Math.Pow(value, i + 2);
            }

            return p;
        }
    }
}