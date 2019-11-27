using Algorithms;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;
using System;
using UnitTestProject.Mocks;

namespace UnitTestProject
{
    [TestClass]
    public class LIFOStackTesting
    {
        [TestMethod]
        public void Size_ReturnsCero_WhenInstantiatedWithEmptyLinkedList()
        {
            IStack myStack = new LIFOStack(new LinkedList());

            var actual = myStack.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsCero_WhenInstantiatedWithFakeLinkedList()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            var actual = myStack.Size();

            var expected = 5U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenInstantiatedWithEmptyLinkedList()
        {
            IStack myStack = new LIFOStack(new LinkedList());

            var actual = myStack.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenInstantiatedWithFakeLinkedList()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            var actual = myStack.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Peek_ReturnsLastElementPushed_WhenInstantiatedWithFakeLinkedList()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            var actual = myStack.Peek();

            var expected = 555;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_ReturnsLastElementPushed_WhenPopCalledOnce()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            var actual = myStack.Pop();

            var expected = 555;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsPenultimateElementPushed_AfterPopCalledOnce()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            myStack.Pop();

            var actual = myStack.Peek();

            var expected = 444;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsLastElementPushed_AfterCallingPushOnceUsingAFakeLinkedList()
        {
            IStack myStack = new LIFOStack(new FakeLinkedList());

            myStack.Push(676);

            var actual = myStack.Peek();

            var expected = 676;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_ReturnsElementPushed_AfterCallingPushOnceUsingAnEmptyLinkedList()
        {
            IStack myStack = new LIFOStack(new LinkedList());

            myStack.Push(171);

            var actual = myStack.Peek();

            var expected = 171;

            Assert.AreEqual(expected, actual);
        }
    }
}
