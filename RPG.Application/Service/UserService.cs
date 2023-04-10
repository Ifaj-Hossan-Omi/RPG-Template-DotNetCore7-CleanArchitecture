using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Domain.Models;

namespace RPG.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public Task<List<User>> GetAllUser()
        {
            return _userRepo.GetAllUser();
        }
    }
}
