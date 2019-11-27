using Interfaces;
using System;

namespace Implementations
{
    public class PriorityQueue : IQueue
    {
        private IList priority1;
        private IList priority2;
        private IList priority3;
        private IPredicate predicate;

        public PriorityQueue(IList list1, IList list2, IList list3, IPredicate predicate)
        {
            this.priority1 = list1;
            this.priority2 = list2;
            this.priority3 = list3;
            this.predicate = predicate;
        }

        public object Dequeue()
        {
            object toReturn = null;

            if (this.priority1.Get(0) != null)
            {
                toReturn = this.priority1.Get(0);
                this.priority1.Delete(0);
            }
            else if (this.priority2.Get(0) != null)
            {
                toReturn = this.priority2.Get(0);
                this.priority2.Delete(0);
            }
            else if(this.priority3.Get(0) != null)
            {
                toReturn = this.priority3.Get(0);
                this.priority3.Delete(0);
            }

            return toReturn;
        }

        public void Enqueue(int priority, object toEnqueue)
        {

            switch(priority)
            {
                case 1:
                    this.priority1.Add(toEnqueue);
                    break;

                case 2:
                    this.priority2.Add(toEnqueue);
                    break;

                case 3:
                    this.priority3.Add(toEnqueue);
                    break;
            }
        }
    }
}
