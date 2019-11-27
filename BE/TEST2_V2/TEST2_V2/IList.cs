using System;
using System.Collections.Generic;
using System.Text;

namespace TEST2_V2
{
    public interface IList
    {
        void Add(object toAdd);
        object Get(int pos);
        void Delete(int pos);
        int Size();
    }
}
