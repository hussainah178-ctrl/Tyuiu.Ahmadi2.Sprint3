using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double term = (Math.Pow(a, k) + 0.25) * Math.Sin(k);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return sum;
        }
    }
}