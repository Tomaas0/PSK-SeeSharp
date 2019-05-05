using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Entities;

namespace Application.IServices
{
    public interface IUserService
    {
        void AddUser(User user);
    }
}
