using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IEmployeeRepository : ICrudRepository<Employee, int>
    {
        Employee getByUserId(int userID);
    }
}
