using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamStorefrontAPI.Classes.userdetails;
using static SmartTests.SmartTest;

namespace UnitTests
{
    [TestClass]
    public class UserGameStat_Tests
    {
        [TestMethod]
        public void Constructor_setsDefaults()
        {
            UserGameStat ugs = new UserGameStat();
            //var result = RunTest(SmartTests.Criterias.ValidValue, () => a.Equals(e));

            Assert.AreEqual(false, false);
        }
    }
}
