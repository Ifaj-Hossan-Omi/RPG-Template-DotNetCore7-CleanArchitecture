using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Models;

namespace RPG.Application.Abstraction.Service
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
    }
}
