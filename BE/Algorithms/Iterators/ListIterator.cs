using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterators
{
    public class ListIterator : IIterator
    {
        private IList list;
        public uint index;

        public ListIterator(IList list)
        {
            this.list = list;
            this.index = 0;
        }

        public object Current()
        {
            return this.list.Get(index);
        }

        public void First()
        {
            this.index = 0;
        }

        public bool IsDone()
        {
            return this.index == 0 || this.index == this.list.Size() - 1U;
        }

        public void Last()
        {
            this.index = this.list.Size() - 1U;
        }

        public void Next()
        {
            this.index++;
        }

        public void Previous()
        {
            this.index--;
        }
    }
}
