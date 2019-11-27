using System;

namespace Algorithms
{
    public interface IIterable
    {
        IIterator GetIterator();
    }
}
