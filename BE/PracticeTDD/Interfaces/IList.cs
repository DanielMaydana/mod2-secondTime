using System;

namespace Interfaces
{
    public interface IList
    {
        void Add(object toAdd);

        int IndexOf(object toFind);

        void Insert(object toInsert, int position);

        void Delete(object toDelete);

        object Get(int position);

        int Size();
    }
}
