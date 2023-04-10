using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPG.Application.Abstraction.Repository;
using RPG.Domain.Models;
using RPG.Infrastructure.Data;

namespace RPG.Infrastructure.Repository
{
    public class UserRepository : IUserRepo
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
