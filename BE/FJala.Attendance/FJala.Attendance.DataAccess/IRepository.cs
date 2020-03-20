using System;
using System.Collections.Generic;

namespace FJala.Attendance.DataAccess
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
