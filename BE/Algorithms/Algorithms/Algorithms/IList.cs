using System;
using System.Text;

namespace Algorithms
{
    public interface IList : IIterable
    {
        void Add(object toAdd);

        void Clear();

        bool Contains(object toAdd);

        void Delete(uint index);

        void Delete(object toDel);

        object Get(uint index);

        void Insert(object toInsert, uint pos);

        bool IsEmpty();

        uint IndexOf(object toInsert);

        void Set(object toInsert, uint pos);

        uint Size();
    }
}
