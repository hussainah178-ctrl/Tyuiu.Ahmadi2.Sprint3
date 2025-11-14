using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double x)
        {
            double p = 1;
            double x3 = Math.Pow(x, 3);
            Console.WriteLine($"x³ = {x3}");

            for (int i = 1; i <= 17; i++)
            {
                double term = x3 + i;
                p *= term;
                Console.WriteLine($"i={i}, term={term}, p={p}");
            }
            p += 2;
            Console.WriteLine($"Final result: {p}");
            return Math.Round(p, 3);
        }


        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
