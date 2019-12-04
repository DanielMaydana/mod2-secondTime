using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public interface IGenericStack<T>
    {
        void Push(T toStack);
        T Pop();
        T Peek();
        uint Size();
        bool IsEmpty();
    }
}
