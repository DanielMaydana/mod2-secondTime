using System;

namespace Algorithms
{
    public interface IInnumerate
    {
        object Current();
        bool IsDone();
        void Next();
        void Previous();
        void First();
        void Last();
    }
}
