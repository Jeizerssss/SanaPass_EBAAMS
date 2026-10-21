using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface IUserService
    {
        User authenticate(string username, string password);
        bool updateProfile(int userID, string uFName, string uLName, string uEmail, string uContactNumber);
        bool changePassword(int userID, string currentPassword, string newPassword);
        bool registerUser(User user);
    }
}
