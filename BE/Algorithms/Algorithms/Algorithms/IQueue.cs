using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public interface IQueue
    {
        void Enqueue(object toEnqueue);
        object Dequeue();
        void Clear();
        uint Size();
        bool IsEmpty();
    }
}
