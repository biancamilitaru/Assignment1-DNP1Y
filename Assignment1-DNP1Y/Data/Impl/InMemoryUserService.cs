using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1_DNP1Y.Data.Impl
{
    public class InMemoryUserService: IUserInterface
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "biancaMilitaru",
                    Password = "12345"
                },
                new User()
                {
                    UserName = "milanTolnai",
                    Password = "54321"
                }
            }.ToList();
        }
        
        
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}