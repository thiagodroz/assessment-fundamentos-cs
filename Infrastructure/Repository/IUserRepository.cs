using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public interface IUserRepository
    {
        User GetByUserName(string username);
    }
}
