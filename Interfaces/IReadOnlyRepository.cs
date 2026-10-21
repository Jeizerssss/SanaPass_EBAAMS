using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IReadOnlyRepository<T, TId>
    {
        T getById(TId id);
        IEnumerable<T> getAll();
    }
}
