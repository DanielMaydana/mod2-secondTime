namespace BlueRayStoreUnitTests
{
    using System.Collections.Generic;
    using BlueRayStoreBussinesLogic;
    using BlueRayStoreModel;
    using BlueRayStoreModel.Interface;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CatalogPageUnitTests
    {
        [TestMethod]
        public void Given_AListOfItemsNumberPageAndItemsByPage_When_TheDataIsCorrect_Then_ReturnAPage()
        {
            List<string> genresAvatar = new List<string> { "action", "science fiction" };
            Movie avatar = new Movie { NameMovie = "avatar", Genre = genresAvatar };
            List<string> genresAvengers = new List<string> { "science fiction" };
            Movie avengers = new Movie { NameMovie = "avengers", Genre = genresAvengers };
            List<IItem> movies = new List<IItem> { avatar, avengers };
            CatalogPage catalogPage = new CatalogPage();
            Page resultPage = catalogPage.AddMoviesToPage(movies, 1, 10);
            Page expectedPage = new Page { MoviePageList = movies, PageNumber = 1, ItemsByPage = 10 };
            Assert.AreEqual(expectedPage, resultPage);
        }
    }
}
