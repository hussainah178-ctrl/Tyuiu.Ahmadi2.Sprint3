using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task7.V4.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                -2.62, -3.00, -3.84, -5.79, -11.70,
                0, 9.00, 3.83, 2.53, 1.88, 1.49
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}