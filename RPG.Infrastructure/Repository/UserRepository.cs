using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Application.Abstraction.Repository;
using RPG.Domain.Models;

namespace RPG.Infrastructure.Repository
{
    public class UserRepository : IUserRepo
    {
        public Task<User> GetAllUser()
        {
            throw new NotImplementedException();
        }
    }
}
