using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(0.25);
            Assert.AreEqual(411589.537, result);
        }
    }
}
