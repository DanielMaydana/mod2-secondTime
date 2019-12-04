using Algorithms;
using System;

namespace Stacks
{
    public class GenericLIFOStack<T> : IGenericStack<T>
    {
        IGenericList<T> stackList;

        public GenericLIFOStack(IGenericList<T> list)
        {
            this.stackList = list;
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public T Peek()
        {
            return this.stackList.Get(this.Size() - 1);
        }

        public T Pop()
        {
            T toPop = this.stackList.Get(this.Size() - 1);

            this.stackList.Delete(this.Size() - 1);

            return toPop;
        }

        public void Push(T toStack)
        {
            this.stackList.Add(toStack);
        }

        public uint Size()
        {
            return this.stackList.Size();
        }
    }
}