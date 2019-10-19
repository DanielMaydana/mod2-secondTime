namespace BlueRayStoreUnitTestUI
{
    using System;
    using System.Collections.Generic;
    using BlueRayStore;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ViewRenderUnitTest
    {
        private static ViewRender viewRender;

        [ClassInitialize]
        public static void TestInitialize(TestContext context)
        {
            viewRender = new ViewRender();
        }

        [TestMethod]
        public void Given_Header_When_ConvertNameToString_Then_ReturnNameString()
        {
            string result = viewRender.RenderHeader("Store");
            string expectedResult = "                                                                                                                              Store";
            Assert.AreEqual(expectedResult, result.Substring(0, 131));
        }

        [TestMethod]
        public void Given_aPage_When_ConvertPageToString_Then_ReturnPageString()
        {
            List<IItem> listMovies = new List<IItem>() { new Movie { Id = 1, NameMovie = "Avengers" }, new Movie { Id = 2, NameMovie = "Dumbo" }, new Movie { Id = 3, NameMovie = "X-men" } };
            Page page = new Page() { ItemsByPage = 1, PageNumber = 1, MoviePageList = listMovies };
            string result = viewRender.RenderBody(page);
            int expectedResult = 218;
            Assert.AreEqual(expectedResult, result.Length);
        }

        [TestMethod]
        public void Given_aPage_When_ThePageIsZero_Then_ReturnExceptionMessage()
        {
            Page page = new Page() { PageNumber = 0 };
            var exception = Assert.ThrowsException<ArgumentException>(() => viewRender.RenderBody(page));
            var expectedResult = "Page 0 can't exist in the catalog";
            Assert.AreEqual(expectedResult, exception.Message);
        }

        [TestMethod]
        public void Given_aPage_When_ListMoviesIsZero_Then_ReturnExceptionMessage()
        {
            Page page = new Page() { PageNumber = 0 };
            var exception = Assert.ThrowsException<ArgumentException>(() => viewRender.RenderBody(page));
            var expectedResult = "Page 0 can't exist in the catalog";
            Assert.AreEqual(expectedResult, exception.Message);
        }

        [TestMethod]
        public void Given_aPagse_When_ConvertPageToString_Then_ReturnPageString()
        {
            List<string> listOptions = new List<string>() { "option" };
            string result = viewRender.RenderOptions(listOptions);
            int expectedResult = 253;
            Assert.AreEqual(expectedResult, result.Length);
        }

        [TestMethod]
        public void Given_aDataToAMovie_When_theProcessIsWellDone_Then_shouldReturnAStringWithAFormatToShow()
        {
            List<string> genres = new List<string> { "action", "cience fiction" };

            Movie avatar = new Movie { NameMovie = "avatar", ReleaseDate = new DateTime(2019, 4, 2), Genre = genres };

            string result = viewRender.ToStringMovie(avatar);
            string expectedResult = "avatar                             4/2/2019 		action,cience fiction";
            Assert.AreEqual(expectedResult.Length, result.Length);
        }

        [TestMethod]
        public void Given_EmptyDataToAMovie_When_theProcessIsWellDone_Then_shouldReturnAStringEmpty()
        {
            Movie avatar = new Movie();
            string result = viewRender.ToStringMovie(avatar);
            string expectedResult = string.Empty;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Given_NameMovieAndReleaseMoviwToAMovie_When_theProcessIsWellDone_Then_shouldReturnNameMovieAndReleaseMovie()
        {
            Movie avatar = new Movie { NameMovie = "Avengers", ReleaseDate = new DateTime(2019, 04, 03) };
            string result = viewRender.ToStringMovie(avatar);
            string expectedResult = "Avengers                          03/04/2019";
            Assert.AreEqual(expectedResult.Length, result.Length);
        }

        [TestMethod]
        public void Given_NameMovieLongerThan30_When_theProcessIsWellDone_Then_shouldReturnNameMovieReduce()
        {
            Movie avatar = new Movie { NameMovie = "Avengers the infinit war episode two", ReleaseDate = new DateTime(2019, 11, 3) };
            string result = viewRender.ToStringMovie(avatar);
            string expectedResult = "Avengers the infinit war ep...     3/11/2019";
            Assert.AreEqual(expectedResult.Length, result.Length);
        }
    }
}
