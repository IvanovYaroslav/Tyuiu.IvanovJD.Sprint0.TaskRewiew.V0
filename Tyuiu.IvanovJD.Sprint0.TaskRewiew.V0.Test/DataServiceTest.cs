using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint0.TaskRewiew.V0.Lib;
namespace Tyuiu.IvanovJD.Sprint0.TaskRewiew.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(90, DataService.Calc(2, 7, 9));
        }
    }
};
