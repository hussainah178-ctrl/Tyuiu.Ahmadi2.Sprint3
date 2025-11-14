using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task5.V18.Lib
{
    public class DataService : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumTotal = 0;
            int i = startValue1;

            do
            {
                double sumInner = 0;
                int k = startValue2;

                do
                {
                    double term = Math.Cos(x) + (Math.Pow(k, 2) / 2);
                    sumInner += term;
                    k++;
                }
                while (k <= stopValue2);

                sumTotal += sumInner;
                i++;
            }
            while (i <= stopValue1);

            return Math.Round(sumTotal, 3);
        }
    }
}