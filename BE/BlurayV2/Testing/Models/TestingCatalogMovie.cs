using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Testing.Models
{
    [TestClass]
    public class TestingCatalogMovie
    {
        [TestMethod]
        public void CatalogMovieConstructor_InstantiatesCorrectly_WhenGivenAllConstructedParameters()
        {
            CatalogMovie myMovie = new CatalogMovie("Unknown Brother", 1989, "Patrick Carney", 1001);

            string expectedName = "Unknown Brother";
            uint expectedCode = 1001;

            Assert.AreEqual(expectedName, myMovie.Name);
            Assert.AreEqual(expectedCode, myMovie.CatalogCode);
        }

        [TestMethod]
        public void CatalogMovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheEnd()
        {
            CatalogMovie myMovie = new CatalogMovie("Unknown Brother ", 1989, "Patrick Carney", 1001);

            string expectedName = "Unknown Brother";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void CatalogMovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheBeginning()
        {
            CatalogMovie myMovie = new CatalogMovie(" Unknown Brother", 1989, "Patrick Carney", 1001);

            string expectedName = "Unknown Brother";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void CatalogMovieEquals_ReturnsATrueValue_WhenComparedTwoIdenticalMovies()
        {
            CatalogMovie myMovieA = new CatalogMovie("Unknown Brother", 1989, "Patrick Carney", 1001);
            CatalogMovie myMovieB = new CatalogMovie("Unknown Brother", 1989, "Patrick Carney", 1001);

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = true;

            Assert.AreEqual(expectedEval, eval);
        }

        [TestMethod]
        public void CatalogMovieEquals_ReturnsAFalseValue_WhenComparedTwoNonIdenticalMovies()
        {
            CatalogMovie myMovieA = new CatalogMovie("Unknown Brother", 1989, "Patrick Carney", 1001);
            CatalogMovie myMovieB = new CatalogMovie("Unknown Brother", 2011, "Patrick Carney", 2001);

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = false;

            Assert.AreEqual(expectedEval, eval);
        }
    }
}
