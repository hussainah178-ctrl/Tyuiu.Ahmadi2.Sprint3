using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task4.V27.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);
            double wait = -44.313;

            Assert.AreEqual(wait, result);
        }
    }
}