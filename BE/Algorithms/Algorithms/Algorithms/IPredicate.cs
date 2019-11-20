using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public interface IPredicate
    {
        bool Evaluate(object obj);
    }
}
