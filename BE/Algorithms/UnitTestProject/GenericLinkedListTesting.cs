using Algorithms;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class GenericLinkedListTesting
    {
        [TestMethod]
        public void Size_ReturnsDefaultInitialSize_WhenListInstiantiated()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenListInstiantiated()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            var actual = myLinkedList.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenInsertedOneElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("48", 0);

            var actual = myLinkedList.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Size_ReturnsOne_WhenInsertedOneElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("48", 0);

            var actual = myLinkedList.Size();

            var expected = 1U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsRightSize_WhenInsertedOneElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("48", 0);

            var actual = myLinkedList.Size();

            var expected = 1U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsRightSize_WhenInsertedThreeElements()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);
            myLinkedList.Insert("22", 0);
            myLinkedList.Insert("33", 0);

            var actual = myLinkedList.Size();

            var expected = 3U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsFirstElementInserted_WhenInsertedThreeElementsInThePositionCero()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);
            myLinkedList.Insert("22", 0);
            myLinkedList.Insert("33", 0);

            var actual = myLinkedList.Get(2);

            var expected = "11";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsElementAtMiddlePosition_WhenInsertedThreeElementsInDisorder()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);
            myLinkedList.Insert("22", 0);
            myLinkedList.Insert("33", 1);

            var actual = myLinkedList.Get(1);

            var expected = "33";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsLastPosition_WhenInsertCalledTwiceAndAddCalledOnce()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);
            myLinkedList.Insert("22", 0);
            myLinkedList.Insert("33", 1);
            myLinkedList.Add("44");

            var actual = myLinkedList.Get(3);

            var expected = "44";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsLastPosition_WhenInsertCalledThriceAndAddCalledOnce()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);
            myLinkedList.Insert("22", 0);
            myLinkedList.Insert("33", 1);
            myLinkedList.Add("44");

            var actual = myLinkedList.Get(3);

            var expected = "44";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAsOnlyElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("11", 0);

            var actual = myLinkedList.Contains("11");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Contains_ReturnsFalse_WhenDifferentValueInsertedAsOnlyElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("112", 0);

            var actual = myLinkedList.Contains("11");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Contains_ReturnsFalse_WhenInsertedThreeDifferentValues()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("122", 0);
            myLinkedList.Insert("457", 1);
            myLinkedList.Insert("221", 2);

            var actual = myLinkedList.Contains("111");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAtTheEnd()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("122", 0);
            myLinkedList.Insert("457", 1);
            myLinkedList.Insert("111", 2);

            var actual = myLinkedList.Contains("111");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Contains_ReturnsTrue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Insert("122", 0);
            myLinkedList.Insert("457", 0);
            myLinkedList.Insert("111", 0);

            var actual = myLinkedList.Contains("111");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("111");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            var actual = myLinkedList.IndexOf("111");

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheEnd()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            var actual = myLinkedList.IndexOf("111");

            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsIndexValue_WhenSearchedValueInsertedAtTheMiddle()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            var actual = myLinkedList.IndexOf("457");

            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_ReturnsDefaultIndexValue_WhenSearchedValueIsNonExistent()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            var actual = myLinkedList.IndexOf("222");

            var expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueIsOnlyValue()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("111");

            myLinkedList.Set("222", 0);

            var actual = myLinkedList.Get(0);

            var expected = "222";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheBeginning()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            myLinkedList.Set("222", 0);

            var actual = myLinkedList.Get(0);

            var expected = "222";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheMiddle()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            myLinkedList.Set("222", 1);

            var actual = myLinkedList.Get(1);

            var expected = "222";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSetValue_WhenSearchedValueInsertedAtTheEnd()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");
            myLinkedList.Add("457");
            myLinkedList.Add("111");

            myLinkedList.Set("222", 2);

            var actual = myLinkedList.Get(2);

            var expected = "222";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsZero_WhenDeletedOnlyElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");

            myLinkedList.Delete(0);

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenDeletedOnlyElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("122");

            myLinkedList.Delete(0);

            var actual = myLinkedList.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Size_ReturnsUpdatedSize_WhenDeletedLastElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("555");
            myLinkedList.Add("888");
            myLinkedList.Add("909");

            myLinkedList.Delete(2);

            var actual = myLinkedList.Size();

            var expected = 2U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedLastElement_WhenDeletedLastElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("555");
            myLinkedList.Add("888");
            myLinkedList.Add("909");

            myLinkedList.Delete(2);

            var actual = myLinkedList.Get(1);

            var expected = "888";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedFirstElement_WhenDeletedFirstElement()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("555");
            myLinkedList.Add("888");
            myLinkedList.Add("909");

            myLinkedList.Delete(0U);

            var actual = myLinkedList.Get(0U);

            var expected = "888";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPosition1_WhenDeletedElementAtPosition1()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("555");
            myLinkedList.Add("888");
            myLinkedList.Add("909");

            myLinkedList.Delete(1);

            var actual = myLinkedList.Get(1);

            var expected = "909";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPosition2_WhenDeletedElementAtPosition2()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("515");
            myLinkedList.Add("808");
            myLinkedList.Add("909");
            myLinkedList.Add("121");
            myLinkedList.Add("858");

            myLinkedList.Delete(2);

            var actual = myLinkedList.Get(2);

            var expected = "121";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedElementAtPositionTwo_WhenDeletedAnElementAtTheMiddle()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("515");
            myLinkedList.Add("808");
            myLinkedList.Add("909");
            myLinkedList.Add("121");
            myLinkedList.Add("858");

            myLinkedList.Delete("909");

            var actual = myLinkedList.Get(2);

            var expected = "121";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedFirstElement_WhenDeletedAnElementAtTheBeginning()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("515");
            myLinkedList.Add("808");
            myLinkedList.Add("909");
            myLinkedList.Add("121");
            myLinkedList.Add("858");

            myLinkedList.Delete("515");

            var actual = myLinkedList.Get(0);

            var expected = "808";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsUpdatedLastElement_WhenDeletedAnElementAtTheEnd()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("515");
            myLinkedList.Add("808");
            myLinkedList.Add("909");
            myLinkedList.Add("121");
            myLinkedList.Add("858");

            myLinkedList.Delete("858");

            var actual = myLinkedList.Get(3);

            var expected = "121";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsCero_WhenListIsCleared()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("111");

            myLinkedList.Clear();

            var actual = myLinkedList.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ThrowsException_WhenListIsCleared()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            myLinkedList.Add("111");

            myLinkedList.Clear();

            var actual = Assert.ThrowsException<NullReferenceException>(() => myLinkedList.Get(0));

            var expected = "Object reference not set to an instance of an object.";

            Assert.AreEqual(expected, actual.Message);
        }

        [TestMethod]
        public void Get_ThrowsException_WhenAPositionIsNonExistent()
        {
            IGenericList<string> myLinkedList = new GenericLinkedList<string>();

            var actual = Assert.ThrowsException<ArgumentException>(() => myLinkedList.Get(3));

            var expected = "Position is not valid.";

            Assert.AreEqual(expected, actual.Message);
        }
    }
}
