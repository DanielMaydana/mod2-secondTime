namespace BlueRayStoreUnitTests
{
    using System;
    using System.Collections.Generic;
    using BlueRayStoreBussinesLogic;
    using BlueRayStoreDataAccess;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CatalogUnitTest
    {
        private static Catalog catalog;

        [ClassInitialize]
        public static void TestInitialize(TestContext context)
        {
            catalog = new Catalog();
            catalog.ItemsByPage = 10;
            catalog.PremierRange = 15;
            catalog.FilePath = @"\movies.csv";
            catalog.Folder = @"C:\Movie";
        }

        [TestMethod]
        public void Given_ListOfMovies_When_GetPageIsCorrect_Then_ReturnListOfPages()
        {
            catalog.ItemsByPage = 1;
            catalog.MovieList = new List<IItem> { new Movie { Id = 1, NameMovie = "Avengers" }, new Movie { Id = 2, NameMovie = "Dumbo" }, new Movie { Id = 3, NameMovie = "X-men" } };
            var result = catalog.GetMovieCatalog();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void Given_ListOfMovies_When_ListOfPagesIsEmpty_Then_ReturnExceptionMessage()
        {
            catalog.MovieList = new List<IItem>();
            var exception = Assert.ThrowsException<ArgumentException>(() => catalog.GetMovieCatalog());
            var expectedResult = "This Catalog does not contain any movie yet.";
            Assert.AreEqual(expectedResult, exception.Message);
        }

        [TestMethod]
        public void Given_AMovieList_When_GetTheMovieList_Then_ReturnValidList()
        {
            TemporaryDataBase expectedResult = new TemporaryDataBase();
            catalog.MovieList = expectedResult.MovieList;
            var movieList = new List<IItem>();
            movieList.Add(new Movie { Id = 100, Genre = new List<string> { "Action" }, NameMovie = "Uri: The Surgical Strike", ReleaseDate = new DateTime(2018, 1, 11), UploadDate = new DateTime(2019, 4, 2) });
            Assert.AreEqual(catalog.MovieList[0].Id, movieList[0].Id);
        }

        [TestMethod]
        public void Given_AMovieList_When_GetMovieOrderByPremier_Then_ReturnValidList()
        {
            TemporaryDataBase expectedResult = new TemporaryDataBase();
            catalog.MovieList = expectedResult.MovieList;
            List<Page> listResult = catalog.GetPremierCatalog();

            var movieWithDataValid = new Movie { Id = 103, Genre = new List<string> { "Drama" }, NameMovie = "Why Cheat India", ReleaseDate = new DateTime(2019, 4, 11), UploadDate = new DateTime(2019, 4, 2) };
            List<Page> listExpected = new List<Page>() {
                new Page() { ItemsByPage = 1, PageNumber = 1, MoviePageList = new List<IItem> { movieWithDataValid } },
                new Page() { ItemsByPage = 1, PageNumber = 1, MoviePageList = new List<IItem> { movieWithDataValid } }
            };
            
            Assert.AreEqual(listExpected.Count, listResult.Count);
        }

        [TestMethod]
        public void Given_RequestList_When_ThePathDoesNotExist_Then_ReturnExceptionMessage()
        {
            catalog.FilePath = "";
            var exception = Assert.ThrowsException<ArgumentException>(() => catalog.SetMovieList());
            string expectedResult = @"File not found! Be sure the file is in the specified folder C:\Movie";
            Assert.AreEqual(expectedResult, exception.Message);
        }
    }
}