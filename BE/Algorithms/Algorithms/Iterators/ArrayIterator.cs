using Algorithms;
using System;

namespace Iterators
{
    public class ArrayIterator : IIterator
    {
        private object[] objArray;
        private uint index;
        private uint start;
        private uint finish;

        public ArrayIterator(object[] array)
        {
            this.objArray = array;
            this.index = this.start = 0;
            this.finish = (uint)array.Length - 1;
        }

        public ArrayIterator(object[] array, uint start, uint length) : this(array)
        {
            this.index = this.start = start - 1;
            this.finish = this.index + length - 1;
        }

        public object Current()
        {
            return this.objArray[index];
        }

        public bool IsDone()
        {
            return this.index <= this.start || this.index >= this.finish;
        }

        public void Next()
        {
            this.index++;
        }

        public void Previous()
        {
            this.index--;
        }

        public void First()
        {
            this.index = 0;
        }

        public void Last()
        {
            this.index = this.finish;
        }
    }
}
