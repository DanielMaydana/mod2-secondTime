using System;

namespace Interfaces
{
    public interface IQueue
    {
        void Enqueue(int priority, object toEnqueue);

        object Dequeue();
    }
}
