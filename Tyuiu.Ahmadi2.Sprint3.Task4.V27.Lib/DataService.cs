using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            int x = startValue;

            while (x <= stopValue)
            {
                if (x != 0) 
                {
                    double denominator = Math.Cos(x) - Math.Sin(x);

                    if (Math.Abs(denominator) > 0.0001)
                    {
                        double y = x / denominator;
                        sum += y;
                    }
                }
                x++;
            }

            return Math.Round(sum, 3);
        }
    }
}