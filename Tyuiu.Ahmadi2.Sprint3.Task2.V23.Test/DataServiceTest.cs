using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task2.V23.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 1.5;
            int startValue = 1;
            int stopValue = 13;

            double result = ds.GetSumSeries(a, startValue, stopValue);
            double wait = -4.567;

            Assert.AreEqual(wait, Math.Round(result, 3));
        }
    }
}