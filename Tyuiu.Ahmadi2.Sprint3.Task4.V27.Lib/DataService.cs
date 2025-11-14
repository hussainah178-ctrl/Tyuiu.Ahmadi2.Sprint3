using System;

namespace Tyuiu.Ahmadi2.Sprint3.Task4.V27.Lib
{
    public class DataService
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                double cosX = Math.Cos(x);
                double sinX = Math.Sin(x);
                double denominator = cosX - sinX;

                if (Math.Abs(denominator) > 0.0001)
                {
                    double y = x / denominator;
                    sum += y;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}