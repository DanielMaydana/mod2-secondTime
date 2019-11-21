using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public interface IStack
    {
        void Push(object toStack);
        object Pop();
        object Peek();
        uint Size();
        bool IsEmpty();
    }
}
