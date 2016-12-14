using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA3Sample2.Models;

namespace CA3Sample2.Tests.Models
{
    [TestClass]
    public class PropertyTaxServiceTest
    {
        [TestMethod]
        public void TestCalculation()
        {
            PropertyTaxservice pts = new PropertyTaxservice();
            pts.HousePrice = 90000;
            pts.HasSwimmingPool = false;
            Assert.AreEqual(pts.CalculateTax, 90);
            PropertyTaxservice pts1 = new PropertyTaxservice();
            pts1.HousePrice = 220000;
            pts1.HasSwimmingPool = true;
            Assert.AreEqual(pts1.CalculateTax, 10405);
        }
    }
}
