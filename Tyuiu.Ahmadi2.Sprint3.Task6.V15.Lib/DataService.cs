using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.Ahmadi2.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                int sumDivisors = 0;

                
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        sumDivisors += divisor;
                    }
                }

                totalSum += sumDivisors;
            }

            return totalSum;
        }
    }
}