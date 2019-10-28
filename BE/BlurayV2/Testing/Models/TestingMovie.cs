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

        [TestMethod]
        public void MovieEquals_ReturnsATrueValue_WhenComparedTwoIdenticalMovies()
        {
            Movie myMovieA = new Movie("Rival Sons", 1989, "Jay Buchanan");
            Movie myMovieB = new Movie("Rival Sons", 1989, "Jay Buchanan");

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = true;

            Assert.AreEqual(expectedEval, eval);
        }

        [TestMethod]
        public void MovieEquals_ReturnsAFalseValue_WhenComparedTwoNonIdenticalMovies()
        {
            Movie myMovieA = new Movie("Rival Sons", 1989, "Jay Buchanan");
            Movie myMovieB = new Movie("Rival Sons", 2011, "Jay Buchanan");

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = false;

            Assert.AreEqual(expectedEval, eval);
        }
    }
}
