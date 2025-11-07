using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyulu.Ahmadi2.Sprint3.Task1.V15.Lib
{
    public class DataService
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int i = startValue;

            while (i <= stopValue)
            {
                product *= (value * value * i + 1);
                i++;
            }

            return product;
        }
    }
}