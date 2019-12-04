using System;
using System.Text;

namespace Algorithms
{
    public interface IGenericList<T> : IIterable
    {
        void Add(T toAdd);

        void Clear();

        bool Contains(T toAdd);

        void Delete(uint index);

        void Delete(T toDel);

        T Get(uint index);

        void Insert(T toInsert, uint pos);

        bool IsEmpty();

        int IndexOf(T toInsert);

        void Set(T toSet, uint pos);

        uint Size();
    }
}
