using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterators
{
    public class ReverseIterator : IIterator
    {
        private IIterator iterator;
        private object last;

        public ReverseIterator(IIterator iter)
        {
            this.iterator = iter;
            this.last = iter.Current();
            this.iterator.Last();
        }

        public object Current()
        {
            return this.iterator.Current();
        }

        public bool IsDone()
        {
            return this.iterator.Current() == this.last;
        }
        public void Next()
        {
            this.iterator.Previous();
        }
        public void Previous()
        {
            this.iterator.Next();
        }
        public void First()
        {
            this.iterator.Last();
        }

        public void Last()
        {
            this.iterator.First();
        }

    }
}
