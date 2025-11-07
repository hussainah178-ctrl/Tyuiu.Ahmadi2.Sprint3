using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyulu.Ahmadi2.Sprint3.Task1.V15.Lib;

namespace Tyulu.Ahmadi2.Sprint3.Task1.V15.Test
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
            double wait = 208845.0; // : (5×6×7×8×9) + 1 = 15120 + 1 = 15121

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, result);
        }
    }
}