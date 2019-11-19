using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterators
{
    public class ReverseIterator : IInnumerate
    {
        private IInnumerate iterator;
        private object first;

        public ReverseIterator(IInnumerate iter)
        {
            this.iterator = iter;
            this.first = iter.Current();
            this.iterator.Last();
        }

        public object Current()
        {
            return this.iterator.Current();
        }

        public bool IsDone()
        {
            return this.iterator.Current() == this.first;
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
