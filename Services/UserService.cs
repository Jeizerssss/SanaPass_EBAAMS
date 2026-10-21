using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public User authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return _userRepository.validateLogin(username, password);
        }

        public bool updateProfile(int userID, string uFName, string uLName, string uEmail, string uContactNumber)
        {
            var user = _userRepository.getById(userID);
            if (user == null)
            {
                return false;
            }

            // Update user profile properties
            user.uFName = uFName;
            user.uLName = uLName;
            user.uEmail = uEmail;
            user.uContactNumber = uContactNumber;

            return _userRepository.update(user);
        }

        public bool changePassword(int userID, string currentPassword, string newPassword)
        {
            var user = _userRepository.getById(userID);
            if (user == null || user.password != currentPassword)
            {
                return false; // Invalid existing credentials
            }

            user.password = newPassword;
            return _userRepository.update(user);
        }

        public bool registerUser(User user)
        {
            if (user == null) return false;

            // Check if username is already taken
            var existingUser = _userRepository.getByUsername(user.username);
            if (existingUser != null)
            {
                return false; // Username already exists
            }

            return _userRepository.add(user);
        }
    }
}
