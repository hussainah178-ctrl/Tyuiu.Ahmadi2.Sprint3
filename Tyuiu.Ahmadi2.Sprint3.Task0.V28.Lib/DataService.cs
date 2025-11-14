using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double x)
        {
            double sum = 0; 
            double x3 = Math.Pow(x, 3);

            for (int i = 1; i <= 17; i++)
            {
                sum  += x3 * i;
            }
            return 2 + sum;     
        }


        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
