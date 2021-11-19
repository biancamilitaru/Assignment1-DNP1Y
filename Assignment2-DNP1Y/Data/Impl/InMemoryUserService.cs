using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

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
                    Domain = "via.dk",
                    Password = "12345"
                },
                new User()
                {
                    UserName = "milanTolnai",
                    Domain = "milan@hotmail.com",
                    Password = "54321"
                }
            }.ToList();
        }

        public async Task<User> GetUserAsync(string username)
        {
            foreach (User user in users)
            {
                if (user.UserName.Equals(username))
                    return user;
            }

            return null;
        }
    }
}