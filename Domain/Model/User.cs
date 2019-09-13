using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Friend> Friends { get; set; }

        public void AddFriend(string firstName, string surname, DateTime birthday)
        {

        }
    }
}
