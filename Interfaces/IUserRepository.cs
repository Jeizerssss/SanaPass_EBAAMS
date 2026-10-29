using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IUserRepository : ICrudRepository<User, int>
    {
        User getByUsername(string username);
        User validateLogin(string username, string password);

    }
}
