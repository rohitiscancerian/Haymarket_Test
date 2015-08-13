using System;
using NUnit.Framework;
using CodeTest.Haymarket.Speed.Valetservice;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestSpeedValetService()
        {
            SpeedvaletService obj = new SpeedvaletService();

            Assert.AreEqual("£79.99",obj.RequestAQuote("BRONZE", "small"));
            Assert.AreEqual("£89.99",obj.RequestAQuote("Silver", "Mini"));
            Assert.AreEqual("£117.89",obj.RequestAQuote("gold", "4x4")); // 10% off on 130.99 = 117.89
            Assert.AreEqual("£90.89", obj.RequestAQuote("silver", "mpv")); // 10% off on 100.99 = 90.89 

        }
    }
}
