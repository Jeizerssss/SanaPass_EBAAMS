using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;

namespace SanaPass_EBAAMS.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository
                ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public User login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return _userRepository.validateLogin(
                username.Trim(),
                password);
        }

        public bool register(User newUser)
        {
            if (newUser == null ||
                string.IsNullOrWhiteSpace(newUser.username) ||
                string.IsNullOrWhiteSpace(newUser.password))
            {
                return false;
            }

            User existingUser = _userRepository.getByUsername(newUser.username);

            if (existingUser != null)
            {
                return false;
            }

            return _userRepository.add(newUser);
        }
    }
}
