using Algorithms;
using System;

namespace Queues
{
    public class FIFOQueue : IQueue
    {
        IList QueueList;

        public FIFOQueue(IList list)
        {
            this.QueueList = list;
        }

        public void Clear()
        {
            this.QueueList.Clear();
        }

        public object Dequeue()
        {
            object toDequeue = this.QueueList.Get(0);

            this.QueueList.Delete(0);

            return toDequeue;
        }

        public void Enqueue(object toEnqueue)
        {
            this.QueueList.Add(toEnqueue);
        }

        public bool IsEmpty()
        {
            return this.QueueList.IsEmpty();
        }

        public uint Size()
        {
            return this.QueueList.Size();
        }
    }
}
