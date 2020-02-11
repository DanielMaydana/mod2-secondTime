using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public interface IContext<T>
    {
        public List<T> GetAll();
    }
}
