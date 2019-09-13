using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool ComparePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}
}
