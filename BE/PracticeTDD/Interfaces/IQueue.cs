using System;

namespace Interfaces
{
    public interface IQueue
    {
        void Enqueue(object toEnqueue);

        object Dequeue();

        int Size();

        bool IsEmpty();
    }
}
