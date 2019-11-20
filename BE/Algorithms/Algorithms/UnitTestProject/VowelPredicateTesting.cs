using Algorithms;
using Iterators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Predicates;

namespace UnitTestProject
{
    [TestClass]
    public class VowelPredicateTesting
    {
        [TestMethod]
        public void Evaluate_ReturnsTrue_WhenPassedAVowel()
        {
            VowelPredicate myPredicate = new VowelPredicate();

            var actual = myPredicate.Evaluate('a');

            var expected = true;

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Evaluate_ReturnsFalse_WhenPassedNotAVowel()
        {
            VowelPredicate myPredicate = new VowelPredicate();

            var actual = myPredicate.Evaluate('f');

            var expected = false;

            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void Current_ReturnsSecondPosition_WhenTheBaseArrayFirstElementIsNotAVowel()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'w', 'a', 'b', 'c', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            var actual = myFilterIterator.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenTheBaseArrayFirstElementIsAVowel()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            var actual = myFilterIterator.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsThirdVowel_WhenLastIsCalled()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 's', 'a', 'i', 'b', 'c', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Last();

            var actual = myFilterIterator.Current();

            var expected = 'e';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsSecondVowel_WhenNextIsCalledOnce()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'z', 'a', 'b', 'c', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Next();

            var actual = myFilterIterator.Current();

            var expected = 'e';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsSecondVowel_WhenPreviousIsCalledOnce()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'z', 'a', 'b', 'i', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Last();

            myFilterIterator.Previous();

            var actual = myFilterIterator.Current();

            var expected = 'i';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsMiddlePosition_WhenLastAndFirstCalledOnce()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'a', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Last();

            var actual = myFilterIterator.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsFourthPosition_WhenArrayStartedAtSecondPosition()
        {
            uint start = 2, length = 5;

            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'e', 'a', 'b', 'i', 'd', 'e', 'f' }, start, length);

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Last();

            var actual = myFilterIterator.Current();

            var expected = 'i';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenLastIsCalledOnce()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'e', 'a', 'b', 'i', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.Last();

            var actual = myFilterIterator.IsDone();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenFirstIsCalledOnce()
        {
            IIterator baseArray = new ArrayIterator(new object[] { 'x', 'e', 'a', 'b', 'i', 'd', 'e', 'f' });

            IPredicate vowelPredicate = new VowelPredicate();

            IIterator myFilterIterator = new FilterIterator(baseArray, vowelPredicate);

            myFilterIterator.First();

            var actual = myFilterIterator.IsDone();

            Assert.IsTrue(actual);
        }

    }
}