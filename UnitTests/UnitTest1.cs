using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmartTests.Criterias;
using SteamStorefrontAPI.Classes;
using static SmartTests.SmartTest;

namespace UnitTests
{
    [TestClass]
    public class PriceOverview_Test
    {
        [TestMethod] 
        public void Equals_AreEquel()
        {
            Mock<PriceOverview> mockPO = new Mock<PriceOverview>();
            PriceOverview a = new PriceOverview();
            PriceOverview e = new PriceOverview();
            a.Final = 10.0;
            a.Currency = "USD";
            a.Initial = 1.0;
            e.Final = a.Final;
            e.Currency = a.Currency;
            e.Initial = a.Initial;
            var result = RunTest( Equality.AreEqual, () => a.Equals(e));

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Equals_AreSame()
        {
            Mock<PriceOverview> mockPO = new Mock<PriceOverview>();
            PriceOverview a = new PriceOverview();
            a.Final = 10.0;
            a.Currency = "USD";
            a.Initial = 1.0;
            var result = RunTest(Equality.AreSame, () => a.Equals(a));

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Equals_AreDifferent()
        {
            Mock<PriceOverview> mockPO = new Mock<PriceOverview>();
            PriceOverview a = new PriceOverview();
            PriceOverview e = new PriceOverview();
            a.Final = 10.0;
            a.Currency = "USD";
            a.Initial = 1.0;
            e.Final = 1.0;
            e.Currency = a.Currency;
            e.Initial = a.Initial;
            var result = RunTest(Equality.AreDifferent, () => a.Equals(e));

            Assert.AreEqual(false, result);
        }
    }
}
