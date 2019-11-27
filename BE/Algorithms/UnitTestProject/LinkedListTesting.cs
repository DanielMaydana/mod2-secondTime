using Algorithms;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

            var actual = myLinkedList.Get(2);

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

            var actual = myLinkedList.Get(1);

            var expected = 33;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsLastPosition_WhenInsertCalledTwiceAndAddCalledOnce()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);
            myLinkedList.Insert((object)22, 0);
            myLinkedList.Insert((object)33, 1);
            myLinkedList.Add((object)44);

            var actual = myLinkedList.Get(3);

            var expected = 44;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsLastPosition_WhenInsertCalledThriceAndAddCalledOnce()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);
            myLinkedList.Insert((object)22, 0);
            myLinkedList.Insert((object)33, 1);
            myLinkedList.Add((object)44);

            var actual = myLinkedList.Get(3);

            var expected = 44;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAsOnlyElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)11, 0);

            var actual = myLinkedList.Contains(11);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Contains_ReturnsFalse_WhenDifferentValueInsertedAsOnlyElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)112, 0);

            var actual = myLinkedList.Contains(11);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Contains_ReturnsFalse_WhenInsertedThreeDifferentValues()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)122, 0);
            myLinkedList.Insert((object)457, 1);
            myLinkedList.Insert((object)221, 2);

            var actual = myLinkedList.Contains(111);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAtTheEnd()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)122, 0);
            myLinkedList.Insert((object)457, 1);
            myLinkedList.Insert((object)111, 2);

            var actual = myLinkedList.Contains(111);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Insert((object)122, 0);
            myLinkedList.Insert((object)457, 0);
            myLinkedList.Insert((object)111, 0);

            var actual = myLinkedList.Contains(111);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)111);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            var actual = myLinkedList.IndexOf(111);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheEnd()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            var actual = myLinkedList.IndexOf(111);

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheMiddle()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            var actual = myLinkedList.IndexOf(457);

            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsDefaultIndexValue_WhenSearchedValueIsNonExistent()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            var actual = myLinkedList.IndexOf(222);

            var expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueIsOnlyValue()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)111);

            myLinkedList.Set((object)222, 0);

            var actual = myLinkedList.Get(0);

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            myLinkedList.Set((object)222, 0);

            var actual = myLinkedList.Get(0);

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheMiddle()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            myLinkedList.Set((object)222, 1);

            var actual = myLinkedList.Get(1);

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheEnd()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);
            myLinkedList.Add((object)457);
            myLinkedList.Add((object)111);

            myLinkedList.Set((object)222, 2);

            var actual = myLinkedList.Get(2);

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsZero_WhenDeletedOnlyElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);

            myLinkedList.Delete(0);

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenDeletedOnlyElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)122);

            myLinkedList.Delete(0);

            var actual = myLinkedList.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Size_ReturnsUpdatedSize_WhenDeletedLastElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)555);
            myLinkedList.Add((object)888);
            myLinkedList.Add((object)909);

            myLinkedList.Delete(2);

            var actual = myLinkedList.Size();

            var expected = 2U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedLastElement_WhenDeletedLastElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)555);
            myLinkedList.Add((object)888);
            myLinkedList.Add((object)909);

            myLinkedList.Delete(2);

            var actual = myLinkedList.Get(1);

            var expected = 888;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedFirstElement_WhenDeletedFirstElement()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)555);
            myLinkedList.Add((object)888);
            myLinkedList.Add((object)909);

            myLinkedList.Delete(0);

            var actual = myLinkedList.Get(0);

            var expected = 888;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPosition1_WhenDeletedElementAtPosition1()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)555);
            myLinkedList.Add((object)888);
            myLinkedList.Add((object)909);

            myLinkedList.Delete(1);

            var actual = myLinkedList.Get(1);

            var expected = 909;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPosition2_WhenDeletedElementAtPosition2()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)515);
            myLinkedList.Add((object)808);
            myLinkedList.Add((object)909);
            myLinkedList.Add((object)121);
            myLinkedList.Add((object)858);

            myLinkedList.Delete(2);

            var actual = myLinkedList.Get(2);

            var expected = 121;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPositionTwo_WhenDeletedAnElementAtTheMiddle()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)515);
            myLinkedList.Add((object)808);
            myLinkedList.Add((object)909);
            myLinkedList.Add((object)121);
            myLinkedList.Add((object)858);

            myLinkedList.Delete((object)909);

            var actual = myLinkedList.Get(2);

            var expected = 121;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedFirstElement_WhenDeletedAnElementAtTheBeginning()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)515);
            myLinkedList.Add((object)808);
            myLinkedList.Add((object)909);
            myLinkedList.Add((object)121);
            myLinkedList.Add((object)858);

            myLinkedList.Delete((object)515);

            var actual = myLinkedList.Get(0);

            var expected = 808;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedLastElement_WhenDeletedAnElementAtTheEnd()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add((object)515);
            myLinkedList.Add((object)808);
            myLinkedList.Add((object)909);
            myLinkedList.Add((object)121);
            myLinkedList.Add((object)858);

            myLinkedList.Delete((object)858);

            var actual = myLinkedList.Get(3);

            var expected = 121;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsCero_WhenListIsCleared()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add(111);

            myLinkedList.Clear();

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ThrowsException_WhenListIsCleared()
        {
            IList myLinkedList = new LinkedList();

            myLinkedList.Add(111);

            myLinkedList.Clear();

            var actual = Assert.ThrowsException<NullReferenceException>(() => myLinkedList.Get(0));

            var expected = "Object reference not set to an instance of an object.";

            Assert.AreEqual(expected, actual.Message);
        }

        [TestMethod]
        public void Get_ThrowsException_WhenAPositionIsNonExistent()
        {
            IList myLinkedList = new LinkedList();

            var actual = Assert.ThrowsException<ArgumentException>(() => myLinkedList.Get(3));

            var expected = "Position is not valid.";

            Assert.AreEqual(expected, actual.Message);
        }
    }
}
