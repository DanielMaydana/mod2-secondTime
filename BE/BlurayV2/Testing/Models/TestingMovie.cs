using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Testing.Models
{
    [TestClass]
    public class MovieTesting
    {
        [TestMethod]
        public void MovieConstructor_InstantiatesCorrectly_WhenGivenAllConstructedParameters()
        {
            Movie myMovie = new Movie("Rival Sons", 1989, "Jay Buchanan");

            string expectedName = "Rival Sons";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void MovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheEnd()
        {
            Movie myMovie = new Movie("Rival Sons ", 1989, "Jay Buchanan");

            string expectedName = "Rival Sons";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void MovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheBeginning()
        {
            Movie myMovie = new Movie(" Rival Sons", 1989, "Jay Buchanan");

            string expectedName = "Rival Sons";

            Assert.AreEqual(expectedName, myMovie.Name);
        }
    }
}
