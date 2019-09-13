using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetByUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}
}
