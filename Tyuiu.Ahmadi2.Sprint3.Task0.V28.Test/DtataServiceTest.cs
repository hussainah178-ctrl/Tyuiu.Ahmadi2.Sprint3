using System;
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
            double wait = 1.2345678901234568E+28; 

            double res = ds.GetMultiplySeries(x);

            Assert.AreEqual(wait, res);
        }
    }
}