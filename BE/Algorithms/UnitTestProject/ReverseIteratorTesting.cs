using Algorithms;
using Iterators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ReverseIteratorTesting
    {
        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenInstantiatedWithAnArray()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            var actual = myReverseIterator.Current();

            var expected = 'b';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Next_ReturnsSecondPosition_WhenNextIsCalledOnce()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            myReverseIterator.Next();

            var actual = myReverseIterator.Current();

            var expected = 'c';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Previous_ReturnsSecondPosition_WhenGoingForwardTwiceAndBackwardsOnce()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            myReverseIterator.Next();

            myReverseIterator.Next();

            myReverseIterator.Previous();

            var actual = myReverseIterator.Current();

            var expected = 'c';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsLastPosition_WhenLastIsCalled()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            myReverseIterator.Last();

            var actual = myReverseIterator.Current();

            var expected = 'a';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenFirstIsCalled()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            myReverseIterator.First();

            var actual = myReverseIterator.Current();

            var expected = 'd';

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenNextIsCalledThreeTimes()
        {
            ArrayIterator myArrayIter = new ArrayIterator(new object[] { 'a', 'b', 'c', 'd' });

            ReverseIterator myReverseIterator = new ReverseIterator(myArrayIter);

            myReverseIterator.Next();

            myReverseIterator.Next();

            myReverseIterator.Next();

            var actual = myReverseIterator.IsDone();

            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}