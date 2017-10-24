using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAspApp.Models;

namespace SimpleAspTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreation()
        {
            Weather weather = new Weather();
            Assert.AreEqual(weather.Temperature, 65);
        }

        [TestMethod]
        public void TestFailure()
        {
            Weather weather = new Weather();
            Assert.AreEqual(weather.Location, "Seattle");
        }
    }
}
