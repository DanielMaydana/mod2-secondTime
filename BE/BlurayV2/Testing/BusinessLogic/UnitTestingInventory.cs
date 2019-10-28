using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Testing.Mocks;

namespace Testing.BusinessLogic
{
    [TestClass]
    public class InventoryTesting
    {
        [TestMethod]
        public void GetInventoryStore_ReturnsDefaultStockWithZeroQuantity_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            var actualStore = myInventory.GetInventoryStore();

            var expectedStore = new Store<InventoryMovie>()
            {
                new InventoryMovie("In My Time Of Dying", 1975, "Robert Plant", 1001, 1001, 0),
                new InventoryMovie("Houses of The Holy", 1975, "Jimmy Page", 1002, 1002, 0),
                new InventoryMovie("Red Dress", 2002, "Jon Paul Jones", 1003, 1003, 0),
                new InventoryMovie("Night Flight", 1999, "Jeff Buckley", 1004, 1004, 0),
                new InventoryMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005, 1005, 0),
                new InventoryMovie("Alice in Wonderland", 2008, "Alan Moore", 1006, 1006, 0)
            };

            Assert.AreEqual(expectedStore, actualStore);
        }

        [TestMethod]
        public void GetMoviesByName_ReturnsGroupOfMatchingMovies_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            Store<InventoryMovie> actualResults = myInventory.GetMoviesByName("Alice in Wonderland");

            Store<InventoryMovie> expectedResults = new Store<InventoryMovie>()
            {
                new InventoryMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005, 1005, 0),
                new InventoryMovie("Alice in Wonderland", 2008, "Alan Moore", 1006, 1006, 0)
            };

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void GetMovieByCode_ReturnsUniqueMatch_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            InventoryMovie actualMovie = myInventory.GetMovieByCode(1004);

            InventoryMovie expectedMovie = new InventoryMovie("Night Flight", 1999, "Jeff Buckley", 1004, 1004, 0);

            Assert.AreEqual(expectedMovie, actualMovie);
        }
    }
}