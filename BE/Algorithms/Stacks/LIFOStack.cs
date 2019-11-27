using Algorithms;
using System;

namespace Stacks
{
    public class LIFOStack : IStack
    {
        IList stackList;

        public LIFOStack(IList list)
        {
            this.stackList = list;
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public object Peek()
        {
            return this.stackList.Get(this.Size() - 1);
        }

        public object Pop()
        {
            object toPop = this.stackList.Get(this.Size() - 1);

            this.stackList.Delete(this.Size() - 1);

            return toPop;
        }

        public void Push(object toStack)
        {
            this.stackList.Add(toStack);
        }

        public uint Size()
        {
            return this.stackList.Size();
        }
    }
}
