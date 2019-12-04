using Algorithms;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;
using System;
using UnitTestProject.Mocks;

namespace UnitTestProject
{
    [TestClass]
    public class GenericLIFOStackTesting
    {
        [TestMethod]
        public void Size_ReturnsCero_WhenInstantiatedWithEmptyLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());

            var actual = myStack.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsCero_WhenInstantiatedWithGenericLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("555");

            var actual = myStack.Size();

            var expected = 5U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenInstantiatedWithEmptyLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());

            var actual = myStack.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenInstantiatedWithGenericLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("555");

            var actual = myStack.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Peek_ReturnsLastElementPushed_WhenInstantiatedWithGenericLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("555");

            var expected = "555";
            var actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_ReturnsLastElementPushed_WhenPopCalledOnce()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("555");

            var expected = "555";
            var actual = myStack.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsPenultimateElementPushed_AfterPopCalledOnce()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("555");
            myStack.Pop();

            var expected = "444";
            var actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsLastElementPushed_AfterCallingPushOnceUsingAGenericLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("111");
            myStack.Push("222");
            myStack.Push("333");
            myStack.Push("444");
            myStack.Push("676");

            var expected = "676";
            var actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsElementPushed_AfterCallingPushOnceUsingAnEmptyLinkedList()
        {
            IGenericStack<string> myStack = new GenericLIFOStack<string>(new GenericLinkedList<string>());
            myStack.Push("171");

            var expected = "171";
            var actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }
    }
}
