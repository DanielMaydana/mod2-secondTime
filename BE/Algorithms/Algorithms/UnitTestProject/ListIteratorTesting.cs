using Algorithms;
using Iterators;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestProject.Mocks;

namespace UnitTestProject
{
    [TestClass]
    public class ListIteratorTesting
    {
        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenInstantiatedWithAFakeLinkedLlist()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            var actual = myLLIterator.Current();

            var expected = 111;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsFirstPosition_WhenFirstCalled()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.First();

            var actual = myLLIterator.Current();

            var expected = 111;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsLastPosition_WhenLastCalled()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.Last();

            var actual = myLLIterator.Current();

            var expected = 555;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsSecondPosition_WhenNextCalledOnce()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.Next();

            var actual = myLLIterator.Current();

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Current_ReturnsPenultimatePosition_WhenPreviousCalledOnce()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.Last();

            myLLIterator.Previous();

            var actual = myLLIterator.Current();

            var expected = 444;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenLastCalled()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.Last();

            var actual = myLLIterator.IsDone();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsDone_ReturnsTrue_WhenFirstCalled()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.First();

            var actual = myLLIterator.IsDone();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsDone_ReturnsFalse_WhenNextCalledOnce()
        {
            IIterator myLLIterator = new ListIterator(new FakeLinkedList());

            myLLIterator.Next();

            var actual = myLLIterator.IsDone();

            Assert.IsFalse(actual);
        }
    }
}
