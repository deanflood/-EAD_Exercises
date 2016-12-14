using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropertyTaxExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTaxExercise.Tests.Models
{
    [TestClass]
    public class PropertyTaxServiceTest
    {
            [TestMethod]
            public void TaxCost()
            {
            PropertyTaxService taxService1 = new PropertyTaxService();
            PropertyTaxService taxService2 = new PropertyTaxService();
            taxService1.HousePrice = 90000;
            taxService2.HousePrice = 410000;
            Assert.AreEqual(taxService1.PropertyTax, 90);
            Assert.AreEqual(taxService2.PropertyTax, 765);

        }
    }
}
