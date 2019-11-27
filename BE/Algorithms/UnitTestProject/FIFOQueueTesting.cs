using Algorithms;
using Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queues;
using System;
using UnitTestProject.Mocks;

namespace UnitTestProject
{
    [TestClass]
    public class FIFOQueueTesting
    {
        [TestMethod]
        public void Size_ReturnsQueueSize_WhenInstantiatedWithMockLinkedList()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            var actual = myQueue.Size();

            var expected = 5U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsUpdatedQueueSize_WhenEnqueuedASingleElement()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            myQueue.Enqueue((object)656);

            var actual = myQueue.Size();

            var expected = 6U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dequeue_ReturnsFirstElementQueued_WhenInstantiatedWithMockLinkedList()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            var actual = myQueue.Dequeue();

            var expected = 111;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Size_ReturnsCero_WhenQueueCleared()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            myQueue.Clear();

            var actual = myQueue.Size();

            var expected = 0U;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dequeue_ThrowsException_WhenDequeueCalledAfterQueueDepleted()
        {
            IList myList = new LinkedList();

            myList.Add(111);

            IQueue myQueue = new FIFOQueue(myList);

            myQueue.Dequeue();

            var actual = Assert.ThrowsException<NullReferenceException>(() => myQueue.Dequeue());

            var expected = "Object reference not set to an instance of an object.";

            Assert.AreEqual(expected, actual.Message);
        }

        [TestMethod]
        public void Get_ReturnsFirstOriginalQueuedElement_WhenDequeueCalledOnce()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            var actual = myQueue.Dequeue();

            var expected = 111;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_ReturnsSecondOriginalQueuedElement_WhenDequeueCalledTwice()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            myQueue.Dequeue();

            var actual = myQueue.Dequeue();

            var expected = 222;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenQueueInitializedWithEmptyList()
        {
            IQueue myQueue = new FIFOQueue(new LinkedList());

            var actual = myQueue.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsTrue_WhenClearCalledOnce()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            myQueue.Clear();

            var actual = myQueue.IsEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenInstantiatedWithAFakeLinkedList()
        {
            IQueue myQueue = new FIFOQueue(new FakeLinkedList());

            var actual = myQueue.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsEmpty_ReturnsFalse_WhenQueuedASingleElement()
        {
            IQueue myQueue = new FIFOQueue(new LinkedList());

            myQueue.Enqueue(111);

            var actual = myQueue.IsEmpty();

            Assert.IsFalse(actual);
        }
    }
}
