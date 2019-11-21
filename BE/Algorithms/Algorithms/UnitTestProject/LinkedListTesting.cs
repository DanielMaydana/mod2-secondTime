using Algorithms;
using Iterators;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Predicates;

namespace UnitTestProject
{
    [TestClass]
    public class LinkedListTesting
    {
        [TestMethod]
        public void Size_ReturnsDefaultInitialSize_WhenListInstiantiated()
        {
            IList myLinkedList = new LinkedList();

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenListInstiantiated()
        {
            IList myLinkedList = new LinkedList();

            var actual = myLinkedList.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenInsertedOneElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)48, 0);

            var actual = myLinkedList.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Size_ReturnsOne_WhenInsertedOneElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)48, 0);

            var actual = myLinkedList.Size();

            var expected = 1U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsRightSize_WhenInsertedOneElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)48, 0);

            var actual = myLinkedList.Size();

            var expected = 1U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsRightSize_WhenInsertedThreeElements()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);
            myLinkedList.Insert((object)22, 0);
            myLinkedList.Insert((object)33, 0);

            var actual = myLinkedList.Size();

            var expected = 3U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsFirstElementInserted_WhenInsertedThreeElementsInThePositionCero()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);
            myLinkedList.Insert((object)22, 0);
            myLinkedList.Insert((object)33, 0);

            var actual = myLinkedList.Get(3);

            var expected = 11;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsElementAtMiddlePosition_WhenInsertedThreeElementsInDisorder()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);
            myLinkedList.Insert((object)22, 0);
            myLinkedList.Insert((object)33, 1);

            var actual = myLinkedList.Get(2);

            var expected = 33;

            Assert.AreEqual(expected, actual);
        }
    }
}