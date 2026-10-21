using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface ICrudRepository<T, TId> : IReadOnlyRepository<T, TId>
    {
        bool add(T entity);
        bool update(T entity);
        bool delete(TId id);
    }
}
