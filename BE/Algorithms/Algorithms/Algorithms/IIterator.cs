using System;

namespace Algorithms
{
    public interface IIterator
    {
        object Current();
        bool IsDone();
        void Next();
        void Previous();
        void First();
        void Last();
    }
}
