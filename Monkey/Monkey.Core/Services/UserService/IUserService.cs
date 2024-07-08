using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey.Data.Data.Entities;

namespace Monkey.Core.Services.UserService
{
    public interface IUserService
    {
        public Task<User> GetById(int id);
    }
}
