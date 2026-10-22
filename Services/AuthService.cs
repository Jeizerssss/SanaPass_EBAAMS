using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            User user = _userRepository.getByUsername(username);

            // Plaintext comparison or hash verification
            if (user != null && user.password == password)
            {
                return user;
            }

            return null;
        }

        public bool register(User newUser)
        {
            if (newUser == null || string.IsNullOrWhiteSpace(newUser.username))
                return false;

            // Check if username already exists
            User existingUser = _userRepository.getByUsername(newUser.username);
            if (existingUser != null)
                return false;

            return _userRepository.add(newUser);
        }
    }
}
