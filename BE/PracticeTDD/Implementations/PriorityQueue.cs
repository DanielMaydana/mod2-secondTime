using Interfaces;
using System;

namespace Implementations
{
    public class PriorityQueue : IQueue
    {
        private IList list;
        private IPredicate predicate;

        public PriorityQueue(IList list, IPredicate predicate)
        {
            this.list = list;
            this.predicate = predicate;
        }

        public object Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(object toEnqueue)
        {
            this.list.Add(toEnqueue);
        }

        public bool IsEmpty()
        {
            return this.list.Size() == 0;
        }

        public int Size()
        {
            return this.list.Size();
        }
    }
}
