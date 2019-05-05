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

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public void RemoveUser(int id)
        {
            var user = _context.Find<User>(id);
            if(user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
