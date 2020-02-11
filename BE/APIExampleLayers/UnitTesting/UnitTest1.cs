using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using Data;
using FakeData.Context;
using WeatherBusiness;
namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReturnsUmbrella()
        {
            var fr = new Forecast(new RainyContext());
            var actual = fr.GetRecomendation();
            Assert.AreEqual("use umbrella", actual.message);
        }

        [TestMethod]
        public void TestWhenSunnyReturnsSuncream()
        {
            var fr = new Forecast(new SunnyContext());
            var actual = fr.GetRecomendation();

            Assert.AreEqual("use suncream", actual.message);
        }
        
        [TestMethod]
        public void TestWhenNotFoundReturnsNoData()
        {
            var fr = new Forecast(new NoDataContext());
            var actual = fr.GetRecomendation();
            Assert.AreEqual("no data", actual.message);
        }
    }
}
