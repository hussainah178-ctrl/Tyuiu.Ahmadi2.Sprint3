using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Ahmadi2.Sprint3.Task3.V1.Lib;

namespace Tyuiu.Ahmadi2.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'a';

            int result = ds.GetCharCount(value, item);
            int wait = 2;

            Assert.AreEqual(wait, result);
        }
    }
}