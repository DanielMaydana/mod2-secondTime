using BlueRayStoreBussinesLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace BlueRayStoreUnitTests
{
    [TestClass]
    public class StoreUnitTests
    {
        [TestMethod]
        public void Test1()
        {
            NameValueCollection testCollection = new NameValueCollection { { "StoreName", "Movie Store" } };
            ConfigurationsData testConfiguration = new ConfigurationsData(testCollection);
            Store store = new Store(testConfiguration);
            var expectedResult = "Movie Store";
            var result = store.GetStoreName();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
