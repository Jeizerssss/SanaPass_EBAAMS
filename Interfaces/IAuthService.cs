using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IAuthService
    {
        User login(string username, string password);
        bool register(User newUser);
    }
}
