using Algorithms;
using System;

namespace Iterators
{
    public class ArrayIterator : IInnumerate
    {
        private object[] objArray;
        private uint index;

        public object Current()
        {
            return objArray[index];
        }

        public bool IsDone()
        {
            return index == objArray.Length;
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
            this.index = (uint)(objArray.Length - 1);
        }

        public ArrayIterator(object[] array)
        {
            this.index = 0;
            this.objArray = array;
        }
    }
}
