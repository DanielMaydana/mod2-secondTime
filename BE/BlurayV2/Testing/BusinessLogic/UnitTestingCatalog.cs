using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using Testing.Mocks;

namespace Testing.BusinessLogic
{
    [TestClass]
    public class CatalogTesting
    {
        [TestMethod]
        public void AddSingleMovie_ReturnsTheRightMovie_WhenAddedASingleMovie()
        {
            Movie myMovie = new Movie("Rival Sons", 1989, "Jay Buchanan");

            Catalog myCatalog = new Catalog();

            var movieAdded = myCatalog.AddSingleMovie(myMovie);

            var myCatalogMovie = new CatalogMovie("Rival Sons", 1989, "Jay Buchanan", 1001);

            Assert.AreEqual(movieAdded, myCatalogMovie);
        }

        [TestMethod]
        public void GetMovieCount_ReturnsRightCount_WhenAddedFourMovies()
        {
            FakeStore myFakeStore = new FakeStore();

            Catalog myCatalog = new Catalog();

            myCatalog.SetStore(myFakeStore);

            uint expectedCount = 1004;

            Assert.AreEqual(expectedCount, myCatalog.GetMovieCount());
        }

        [TestMethod]
        public void AddSingleMovie_ThrowsException_WhenAddedAExactlyRepeatedMovie()
        {
            Movie myMovieA = new Movie("Rival Sons", 1989, "Jay Buchanan");
            Movie myMovieB = new Movie("Rival Sons", 1989, "Jay Buchanan");

            Catalog myCatalog = new Catalog();

            var movieAddedA = myCatalog.AddSingleMovie(myMovieA);

            var actualException = Assert.ThrowsException<ArgumentException>(() => myCatalog.AddSingleMovie(myMovieB));

            string messageExpected = "The movie 'Rival Sons' (1989) was previously added to the catalog.";

            Assert.AreEqual(messageExpected, actualException.Message);
        }

        [TestMethod]
        public void AddSingleMovie_ThrowsException_WhenAddedARepeatedMovie()
        {
            Movie myMovieA = new Movie("Rival Sons", 1989, "Jay Buchanan");
            Movie myMovieB = new Movie("Rival Sons", 1989, "Jay Buchanan");

            Catalog myCatalog = new Catalog();

            var movieAddedA = myCatalog.AddSingleMovie(myMovieA);

            var actualException = Assert.ThrowsException<ArgumentException>(() => myCatalog.AddSingleMovie(myMovieB));

            string messageExpected = "The movie 'Rival Sons' (1989) was previously added to the catalog.";

            Assert.AreEqual(messageExpected, actualException.Message);
        }

        [TestMethod]
        public void SetStore_ThrowsException_WhenAddedAFakeStoreWithRepeatedMovies()
        {
            FakeDuplicatesStore myFakeDuplicatesStore = new FakeDuplicatesStore();

            Catalog myCatalog = new Catalog();

            var actualException = Assert.ThrowsException<ArgumentException>(() => myCatalog.SetStore(myFakeDuplicatesStore));

            string messageExpected = "The store intended to be assigned, contains duplicates.";

            Assert.AreEqual(messageExpected, actualException.Message);
        }

        [TestMethod]
        public void SetStore_ReturnsRightCatalogStore_WhenPassedAFakeStoreToTheConstructor()
        {
            Catalog myCatalog = new Catalog();

            FakeStore myFakeStore = new FakeStore();

            var myActualStore = myCatalog.SetStore(myFakeStore);

            var expectedStore = new Store<CatalogMovie>()
            {
                new CatalogMovie("Devil's Awaitin' ", 2004, "Peter Hayes", 1001),
                new CatalogMovie(" Dirty Ol' Town'", 20011, "Robert Levon", 1002),
                new CatalogMovie("Burning Jacob's Ladder ", 2006, "Leah Shapiro", 1003),
                new CatalogMovie(" Sound City", 2014, "Dave Grohl", 1004)
            };

            Assert.AreEqual(myActualStore, expectedStore);
        }

        [TestMethod]
        public void GetStore_ReturnsEqualList_WhenAddedMultipleMovies()
        {
            Catalog myCatalog = new Catalog(new FakeStore());

            List<CatalogMovie> moviesExpected = new List<CatalogMovie>()
            {
                new CatalogMovie("Devil's Awaitin'", 2004, "Peter Hayes", 1001),
                new CatalogMovie("Dirty Ol' Town'", 20011, "Robert Levon", 1002),
                new CatalogMovie("Burning Jacob's Ladder", 2006, "Leah Shapiro", 1003),
                new CatalogMovie("Sound City", 2014, "Dave Grohl", 1004)
            };

            Store<CatalogMovie> myExpectedStore = new Store<CatalogMovie>(moviesExpected);

            var actualStore = myCatalog.GetStore();

            Assert.AreEqual(myExpectedStore, actualStore);
        }
    }
}
