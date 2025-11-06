using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task0.V28.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double x = 0.25;
            double wait = 411589.537;

            double res = ds.GetMultiplySeries(x);

            Assert.AreEqual(wait, res);
        }
    }
}