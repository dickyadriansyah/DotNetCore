using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Models;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public gt_para_user Authentication(string username, string password)
        {
            var user = _userRepository.Authentication(username, password);
            return user;
        }

        public async Task<List<gt_para_user>> getAllUsers()
        {
            return await _userRepository.getAllUsers();
        }
    }
}
