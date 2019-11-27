using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public interface IQueue
    {
        void Enqueue(object toEnq);
        object Dequeue();
        bool isEmpty();
    }
}
