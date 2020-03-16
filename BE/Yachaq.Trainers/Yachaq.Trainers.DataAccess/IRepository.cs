using System.Collections.Generic;

namespace Yachaq.Trainers.DataAccess
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}
