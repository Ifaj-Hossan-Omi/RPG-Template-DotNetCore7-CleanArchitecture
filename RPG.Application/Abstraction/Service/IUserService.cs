using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Entity;
using RPG.Domain.ServiceResponse;

// using RPG.Domain.Models.ServiceResponses;

namespace RPG.Application.Abstraction.Service
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetAllUser();
    }
}
