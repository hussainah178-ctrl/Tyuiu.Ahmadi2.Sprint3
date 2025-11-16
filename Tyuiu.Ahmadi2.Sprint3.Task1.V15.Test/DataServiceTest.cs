using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task1.V15.Lib;

namespace Tyuiu.AhmadiM.Sprint3.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 5;
            double wait = 208845.0;

            double res = ds.GetMultiplySeries(value, startValue, stopValue); 
            Assert.AreEqual(wait, res);
        }
    }
}