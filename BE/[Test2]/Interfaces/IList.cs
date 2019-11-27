using System;

namespace Interfaces
{
    public interface IList
    {
        void Add(object toAdd);

        void Clear();

        bool Contains(object toAdd);

        void Delete(uint index);

        void Delete(object toDel);

        object Get(uint index);

        void Insert(object toInsert, uint pos);

        bool IsEmpty();

        int IndexOf(object toInsert);

        void Set(object toSet, uint pos);

        uint Size();
    }
}
