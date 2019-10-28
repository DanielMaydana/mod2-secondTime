using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Testing.Models
{
    [TestClass]
    public class TestingInvevntoryMovie
    {
        [TestMethod]
        public void InventoryMovieConstructor_InstantiatesCorrectly_WhenGivenAllConstructedParameters()
        {
            InventoryMovie myMovie = new InventoryMovie("Ceaseless Sight", 1989, "Marc Ford", 1051, 1002, 0);

            string expectedName = "Ceaseless Sight";
            uint expectedCatalogCode = 1051;
            uint expectedInventoryCode = 1002;
            uint expectedQuantity = 0;

            Assert.AreEqual(expectedName, myMovie.Name);
            Assert.AreEqual(expectedCatalogCode, myMovie.CatalogCode);
            Assert.AreEqual(expectedInventoryCode, myMovie.InventoryCode);
            Assert.AreEqual(expectedQuantity, myMovie.Quantity);
        }

        [TestMethod]
        public void InventoryMovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheEnd()
        {
            InventoryMovie myMovie = new InventoryMovie("Ceaseless Sight ", 1989, "Marc Ford", 1051, 1002, 0);

            string expectedName = "Ceaseless Sight";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void InventoryMovieConstructor_InstantiatesCorrectly_WhenGivenATitleWithExtraSpacesAtTheBeginning()
        {
            InventoryMovie myMovie = new InventoryMovie(" Ceaseless Sight", 1989, "Marc Ford", 1051, 1002, 0);

            string expectedName = "Ceaseless Sight";

            Assert.AreEqual(expectedName, myMovie.Name);
        }

        [TestMethod]
        public void InventoryMovieEquals_ReturnsATrueValue_WhenComparedTwoIdenticalMovies()
        {
            InventoryMovie myMovieA = new InventoryMovie("Ceaseless Sight", 1989, "Marc Ford", 1054, 1002, 0);
            InventoryMovie myMovieB = new InventoryMovie("Ceaseless Sight", 1989, "Marc Ford", 1054, 1002, 0);

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = true;

            Assert.AreEqual(expectedEval, eval);
        }

        [TestMethod]
        public void InventoryMovieEquals_ReturnsAFalseValue_WhenComparedTwoNonIdenticalMovies()
        {
            InventoryMovie myMovieA = new InventoryMovie("Ceaseless Sight", 1989, "Marc Ford", 1054, 1002, 0);
            InventoryMovie myMovieB = new InventoryMovie("One Road Hill", 1989, "Marc Ford", 1054, 1002, 0);

            bool eval = myMovieA.Equals(myMovieB);

            bool expectedEval = false;

            Assert.AreEqual(expectedEval, eval);
        }
    }
}
