using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf3_ReturnsRightWord()
        {
            int number = 9;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "Fizz";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf5_ReturnsRightWord()
        {
            int number = 25;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "Buzz";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOfBoth3And5_ReturnsRightWord()
        {
            int number = 15;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "FizzBuzz";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenANonMultipleOf3_ReturnsRightWord()
        {
            int number = 29;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "29";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenANonMultipleOf5_ReturnsRightWord()
        {
            int number = 31;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "31";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenExactly3_ReturnsRightWord()
        {
            int number = 3;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "Fizz";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenExactly5_ReturnsRightWord()
        {
            int number = 5;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "Buzz";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenCero_ReturnsRightWord()
        {
            int number = 0;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "0";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf7_ReturnsRightWord()
        {
            int number = 14;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "Shazam";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf3And7_ReturnsRightWord()
        {
            int number = 21;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "FizzShazam";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf5And7_ReturnsRightWord()
        {
            int number = 35;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "BuzzShazam";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenAMultipleOf3And5And7_ReturnsRightWord()
        {
            int number = 105;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "FizzBuzzShazam";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenANonMultipleOf7_ReturnsRightWord()
        {
            int number = 11;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();
            string result = myGenerator.Generate(number);

            string expected = "11";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzGenerator_WhenGivenANegativeNumber_ThrowsException()
        {
            int number = -13;

            FizzBuzzGenerator myGenerator = new FizzBuzzGenerator();

            var actualException = Assert.ThrowsException<ArgumentException>(() => myGenerator.Generate(number));
            string expected = "Can't generate word for negative numbers";

            Assert.AreEqual(expected, actualException.Message);
        }
    }
}
