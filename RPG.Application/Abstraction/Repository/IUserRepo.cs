using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Models;

namespace RPG.Application.Abstraction.Repository
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllUser();
    //     Task<User> GetUserByUsername(string username);
    //     Task<User> GetUserByUsernameAndPassword(string username, string password);
    //     Task<User> AddUser(User user);
    //     Task<User> UpdateUser(User user);
    //     Task<bool> DeleteUser(int id);
    }
}
