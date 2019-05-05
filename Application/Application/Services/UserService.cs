using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.IServices;
using Application.Entities;

namespace Application.Services
{
    public class UserService : IUserService
    {
        protected readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
    }
}
