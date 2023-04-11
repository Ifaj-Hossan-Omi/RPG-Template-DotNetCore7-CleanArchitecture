using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.Abstraction.Repository;
using RPG.Application.Abstraction.Service;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

namespace RPG.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<ServiceResponse<List<User>>> GetAllUser()
        {
            var serviceResponse = new ServiceResponse<List<User>>();
            serviceResponse.Data = await _userRepo.GetAllUser();
            return serviceResponse;
        }
    }
}
