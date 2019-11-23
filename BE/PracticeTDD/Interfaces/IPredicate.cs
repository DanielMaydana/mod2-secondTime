using System;

namespace Interfaces
{
    public interface IPredicate
    {
        bool Evaluate(object toEvalA, object toEvalB);
    }
}
