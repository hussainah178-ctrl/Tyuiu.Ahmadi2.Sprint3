using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task6.V15.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 6;
            int stopValue = 15;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 168; 
            Assert.AreEqual(wait, result);
        }
    }
}