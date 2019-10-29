using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
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
                new InventoryMovie("In My Time Of Dying", 1975, "Robert Plant", 1001, 1001, 1),
                new InventoryMovie("Houses of The Holy", 1975, "Jimmy Page", 1002, 1002, 1),
                new InventoryMovie("Red Dress", 2002, "Jon Paul Jones", 1003, 1003, 1),
                new InventoryMovie("Night Flight", 1999, "Jeff Buckley", 1004, 1004, 1),
                new InventoryMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005, 1005, 1),
                new InventoryMovie("Alice in Wonderland", 2008, "Alan Moore", 1006, 1006, 1)
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
                new InventoryMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005, 1005, 1),
                new InventoryMovie("Alice in Wonderland", 2008, "Alan Moore", 1006, 1006, 1)
            };

            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void GetMovieByCode_ReturnsUniqueMatch_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            InventoryMovie actualMovie = myInventory.GetMovieByCode(1004);

            InventoryMovie expectedMovie = new InventoryMovie("Night Flight", 1999, "Jeff Buckley", 1004, 1004, 1);

            Assert.AreEqual(expectedMovie, actualMovie);
        }

        [TestMethod]
        public void GetMovieByCode_ThrowsException_WhenAInventoryCodeIsNotFound()
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            var actualException = Assert.ThrowsException<ArgumentException>(() => myInventory.GetMovieByCode(3024));

            string expectedMessage = "The movie with the code '3024' was not found in the inventory.";

            Assert.AreEqual(expectedMessage, actualException.Message);
        }

        [TestMethod]
        public void AddSingleMovie_ReturnsNewInventoryMovie_WhenAddedASingleCatalogMovie()
        {
            Inventory myInventory = new Inventory();

            CatalogMovie movieToAdd = new CatalogMovie("Hollow Bones", 2017, "Scott Snyder", 1009);

            InventoryMovie actualMovie = myInventory.AddSingleMovie(movieToAdd);

            InventoryMovie expectedMovie = new InventoryMovie("Hollow Bones", 2017, "Scott Snyder", 1009, 1001, 1);

            Assert.AreEqual(expectedMovie, actualMovie);
        }

        [TestMethod]
        public void GetInventoryStore_ReturnsInventoryWithIncrementedQuantities_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeDuplicatesCatalog());

            var actualStore = myInventory.GetInventoryStore();

            var expectedStore = new Store<InventoryMovie>()
            {
                new InventoryMovie("In My Time Of Dying", 1975, "Robert Plant", 1023, 1001, 2),
                new InventoryMovie("Red Dress", 2002, "Jon Paul Jones", 1031, 1002, 3),
                new InventoryMovie("Night Flight", 1999, "Jeff Buckley", 1004, 1003, 1),
                new InventoryMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005, 1004, 1),
                new InventoryMovie("Alice in Wonderland", 2008, "Alan Moore", 1006, 1005, 1)
            };

            Assert.AreEqual(expectedStore, actualStore);
        }

        [TestMethod]
        public void AddSingleMovie_ReturnsInventoryMovieWithIncrementedQuantity_WhenAddedARepeatedCatalogMovie()
        {
            Inventory myInventory = new Inventory();

            CatalogMovie myMovieA = new CatalogMovie("Hollow Bones", 2017, "Scott Snyder", 1009);
            CatalogMovie myMovieB = new CatalogMovie("Hollow Bones", 2017, "Scott Snyder", 1009);

            myInventory.AddSingleMovie(myMovieA);
            var actualMovie = myInventory.AddSingleMovie(myMovieB);

            InventoryMovie expectedMovie = new InventoryMovie("Hollow Bones", 2017, "Scott Snyder", 1009, 1001, 2);

            Assert.AreEqual(expectedMovie, actualMovie);
        }

        [TestMethod]
        public void AddSingleMovie_ReturnsRightInventoryMovie_WhenInventoryInstiantiatedWithASimulatedCatalog()
        {
            Inventory myInventory = new Inventory(new FakeDuplicatesCatalog());

            CatalogMovie myMovie = new CatalogMovie("Red Dress", 2002, "Jon Paul Jones", 1031);

            var actualMovie = myInventory.AddSingleMovie(myMovie);

            InventoryMovie expectedMovie = new InventoryMovie("Red Dress", 2002, "Jon Paul Jones", 1031, 1002, 4);

            Assert.AreEqual(expectedMovie, actualMovie);
        }
    }
}