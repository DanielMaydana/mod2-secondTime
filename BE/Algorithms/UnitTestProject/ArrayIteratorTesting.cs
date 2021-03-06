using Algorithms;
using Iterators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ArrayIteratorTesting
    {
        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenInstantiatedWithAnArray()
        {
            object[] charArray = { 'a', 'b' };

            IIterator myArray = new ArrayIterator(charArray);

            var actual = myArray.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Next_ReturnsSecondPosition_WhenNextIsCalledOnce()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            IIterator myArray = new ArrayIterator(charArray);

            myArray.Next();

            var actual = myArray.Current();

            var expected = 'b';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Previous_ReturnsSecondPosition_WhenGoingForwardTwiceAndBackwardsOnce()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            IIterator myArray = new ArrayIterator(charArray);

            myArray.Next();

            myArray.Next();

            myArray.Previous();

            var actual = myArray.Current();

            var expected = 'b';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsLastPosition_WhenLastIsCalled()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            IIterator myArray = new ArrayIterator(charArray);

            myArray.Last();

            var actual = myArray.Current();

            var expected = 'd';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsLastPosition_WhenFirstIsCalled()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            IIterator myArray = new ArrayIterator(charArray);

            myArray.First();

            var actual = myArray.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenNextIsCalledThreeTimes()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            IIterator myArray = new ArrayIterator(charArray);

            myArray.Next();

            myArray.Next();

            myArray.Next();

            myArray.Next();

            var actual = myArray.IsDone();

            var expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsThirdPosition_WhenUsedTheConstructorWithStartingIndexAndLength()
        {
            object[] charArray = { 'a', 'b', 'c', 'd' };

            uint startingPosition = 3, length = 1;

            IIterator myArray = new ArrayIterator(charArray, startingPosition, length);

            var actual = myArray.Current();

            var expected = 'c';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenUsedTheConstructorWithStartingIndexAndLength()
        {
            object[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

            uint startingPosition = 2, length = 3;

            IIterator myArray = new ArrayIterator(charArray, startingPosition, length);

            myArray.Last();

            var actual = myArray.Current();

            var expected = 'd';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsThirdPosition_WhenStartingFromSecondPositionAndNextCalledOnce()
        {
            object[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

            uint startingPosition = 2, length = 3;

            IIterator myArray = new ArrayIterator(charArray, startingPosition, length);

            myArray.Next();

            var actual = myArray.Current();

            var expected = 'c';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenStartingFromSecondPositionAndLastCalled()
        {
            object[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

            uint startingPosition = 2, length = 3;

            IIterator myArray = new ArrayIterator(charArray, startingPosition, length);

            myArray.Last();

            var actual = myArray.IsDone();

            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
