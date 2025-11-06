using System;
using System.Data;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        private double x;

        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            for (int i = 1; i <= 17; i++)
            {
                p *= (Math.Pow(x, 3) + i) + 2;
            }
            return Math.Round(p, 3);
        }
    }
}
